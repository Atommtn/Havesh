using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using MudBlazor;
using HaveshApp.Model;
using HaveshApp.Services;

namespace HaveshApp.Pages.SiteTransaction
{
    public partial class AttachmentComponent
    {

        [Parameter]
        public string? NoImageFile { get; set; } = "images/noimage.jpg";

        [Parameter]
        public string? ContetnImageFile { get; set; } = "images/FileType.png";

        [Parameter]
        public string UploadButtonText { get; set; } = "Upload";

        [Parameter]
        public string Folder { get; set; } = "Students";

        // [Parameter]
        // public string? ProfilePictureUrl { get; set; }

        [Parameter]
        public EventCallback<string?> ProfilePictureUrlChanged { get; set; }

        [Parameter]
        public string? Error { get; set; }

        [Parameter]
        public EventCallback<string?> ErrorChanged { get; set; }

        [Parameter]
        public Action? UploadStarted { get; set; }

        [Parameter]
        public Action<int>? UploadComplete { get; set; }

        [Parameter]
        public Action<int>? DeleteComplete { get; set; }

        [Inject]
        ILogger<AttachmentComponent> Logger { get; set; }

        bool _showPendingUpload;
        readonly Guid _controlGuid = Guid.NewGuid();
        ShokouhPardisFileAttachment? _attachment;

        [Inject] DataProviderService DataProviderService { get; set; }

        [Parameter]
        public ShokouhPardisFileAttachment? Attachment
        {
            get => _attachment;
            set
            {
                if (_attachment == value)
                    return;

                _attachment = value;
                AttachmentChanged.InvokeAsync(_attachment);
            }
        }

        [Parameter]
        public int MaxUploadFileSizeMB { get; set; } = 4;

        [Parameter]
        public EventCallback<ShokouhPardisFileAttachment?> AttachmentChanged { get; set; }


        CancellationTokenSource UploadCancellationTokenSource = new(TimeSpan.FromSeconds(5));

        private MessageUpdateInvokeHelper? messageUpdateInvokeHelper;
        private void UpdateMessage()
        {
            // message = "UpdateMessage Called!";
            // display = "none";
            StateHasChanged();
        }

        protected override void OnInitialized()
        {
            messageUpdateInvokeHelper = new MessageUpdateInvokeHelper(UpdateMessage);
            base.OnInitialized();
        }

        [JSInvokable]
        public static Task UploadCompressedFileToServer(object file)
        {

            return Task.CompletedTask;
        }


        async Task UploadFiles(InputFileChangeEventArgs e)
        {

            if (Attachment is { })
                await DeleteAttachment();


            var attachmentGuid = Guid.NewGuid();
            try
            {

                _showPendingUpload = true;
                var componentId = "x" + _controlGuid.ToString("N");
                byte[] fileContetn;
                if (e.File.ContentType.StartsWith("image"))
                {
                    fileContetn = await GetCompressedImage(componentId);
                }
                else
                {
                    await using var readStream = e.File.OpenReadStream(MaxUploadFileSizeMB * 1024 * 1024);
                    using var ms = new MemoryStream();
                    await readStream.CopyToAsync(ms);
                    fileContetn = ms.ToArray();
                }

                UploadStarted?.Invoke();

                Attachment = DataProviderService.SaveAttachment(fileContetn, attachmentGuid, Folder, e.File.Name , e.File.ContentType);

                var dataUrl = Attachment.DataUrl;

                //ProfilePictureUrl = dataUrl;
                await ProfilePictureUrlChanged.InvokeAsync(dataUrl);

                Error = null;
                await ErrorChanged.InvokeAsync(Error);

                UploadComplete?.Invoke(Attachment.Id);

                _showPendingUpload = false;
                StateHasChanged();
            }
            catch (TaskCanceledException)
            {
                UploadComplete?.Invoke(-1);
                _showPendingUpload = false;
                await DeleteAttachment();
                //Console.Beep();
                UploadCancellationTokenSource.Dispose();
            }
            // catch (Exception ex)
            // {
            //     Logger.LogError("File: {Filename} Error: {Error}", e.File.Name, ex.Message);
            // }
        }

        [Inject]
        IDialogService DialogService { get; set; }

        async Task RemovePictureClick()
        {
            var delete = await DialogService.ShowMessageBox("حذف تصویر", "آیا از حذف تصویر اطمینان دارید؟", "بله", "خیر");
            if (delete is true)
            {
                await DeleteAttachment();
            }
        }

        async Task DeleteAttachment()
        {
            //var deleteFileAsync = await AwsS3Service.DeleteFileAsync(ProfilePictureUrl);

            var deleteFileAsync = DataProviderService.DeleteAttachment(Attachment);

            if (deleteFileAsync)
            {
                //ProfilePictureUrl = null;
                await ProfilePictureUrlChanged.InvokeAsync(null);
                DeleteComplete?.Invoke(Attachment!.Id);
            }
            Attachment = null;

            StateHasChanged();
        }

        [Inject] IJSRuntime JsRuntime { get; set; }

        private async Task<byte[]> GetCompressedImage(string elementId)
        {

            try
            {
                var tcs = new TaskCompletionSource<byte[]>();
                var promiseHandler = DotNetObjectReference.Create<PromiseHandler>(new PromiseHandler()
                {
                    Tcs = tcs,
                    JsRuntime = JsRuntime,
                    ElementId = elementId
                });

                await JsRuntime.InvokeVoidAsync("imgCls.handleImageUpload", promiseHandler, elementId);
                var bytes = await tcs.Task;
                return bytes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            //var blob = await jsObjectReference.InvokeAsync<IJSObjectReference>("handleImageUpload", "frz");
        }

        public interface IPromiseHandler
        {
            public Task GetDataStream();

            // Set the result of the promise
            void SetResult(byte[] data);

            // Set the error when the promise encounters an exception
            void SetError(string error);
        }

        public class PromiseHandler : IPromiseHandler
        {
            public IJSRuntime JsRuntime { get; init; }
            public TaskCompletionSource<byte[]> Tcs { get; init; }
            public string ElementId { get; init; }

            [JSInvokable]
            public async Task GetDataStream()
            {
                var dataReference = await JsRuntime.InvokeAsync<IJSStreamReference>("imgCls.GetCompresedImageDataStream", ElementId);
                await using var dataReferenceStream =
                    await dataReference.OpenReadStreamAsync(maxAllowedSize: 10_000_000);
                using var ms = new MemoryStream();
                await dataReferenceStream.CopyToAsync(ms);
                var bytes = ms.ToArray();
                Tcs.SetResult(bytes);
            }

            [JSInvokable]
            public void SetResult(byte[] data)
            {
                // Set the results in the TaskCompletionSource
                Tcs.SetResult(data);
            }

            [JSInvokable]
            public void SetError(string error)
            {
                Tcs.SetException(new Exception(error));
            }
        }

    }
}
