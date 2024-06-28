using Havesh.Application.Services;
using Havesh.Domain.Services;
using Havesh.Model.Model;
using HaveshApp.Admin.Definition.Interval;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;


namespace HaveshApp.Admin.Definition.ClassRoom
{
    public partial class ClassRoomDefinitionPage
    {

        [Inject] DataProviderService DataProvider { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }

        List<ShokouhPardisClassRoom>? ClassRoom = null;
        MudTable<ShokouhPardisClassRoom>? table;

        protected override void OnInitialized()
        {
            RefreshData();
            base.OnInitialized();
        }

        void RefreshData()
        {
            ClassRoom = DataProvider.GetClassRooms();

        }

        async Task NewClassRoomClick()
        {
            ShokouhPardisClassRoom classRoom= ShokouhPardisClassRoom.CreateClassRoom();

            await EditButtonClick(classRoom);
        }

        async Task EditButtonClick(ShokouhPardisClassRoom classRoom)
        {
            await OpenNewClassRoomDialog(classRoom);
        }

        async Task OpenNewClassRoomDialog(ShokouhPardisClassRoom classRoom)
        {
            var dialogReference = DialogService.Show<ClassRoomDefinitionDialog>(
                (classRoom.Id > 0 ? "ویرایش " : "جدید ") + "سانس ",
                new DialogParameters
                {
                    ["ClassRoom"] = classRoom
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Large
                });
            var dialogResult = await dialogReference.Result;
            if (dialogResult.Cancelled == false)
            {
                var retData = (ShokouhPardisClassRoom)dialogResult.Data;
                var result = DataProvider.SaveEditClassRoom(retData);
                if (result)
                {
                    var parameters = new DialogParameters();

                    bool? result1 = await DialogService.ShowMessageBox(
                        "خطا",
                        (MarkupString)
                        @$"کلاسی با این نام قبلا ذخیره شده است!
                        <br/>{retData.ClassRoomName}",
                        yesText: "متوجه شدم!");
                }
                else
                {
                    Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                    Log.Warning("User {UserName} Save-Update ClassRoom {ClassRoomId}", _userSession.Payload.UserName, retData.Id);
                }

                RefreshData();
                StateHasChanged();
            }
        }
    }
}
