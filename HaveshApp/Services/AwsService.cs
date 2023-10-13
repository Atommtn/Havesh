using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using Amazon.S3;
using Microsoft.AspNetCore.Components.Forms;
using Olive;
using System.Net;
using Amazon;

namespace ShokouhApp.Services
{
    public class AwsS3Service
    {
        readonly string _region = "eu-west-2";
        readonly string _bucketName;
        readonly IConfiguration _configuration;

        readonly ILogger<AwsS3Service> _logger;

        //string _bucketName = "sahba-co-uk";
        readonly IAmazonS3 _s3Client;


        readonly long maxFileSize = 1024 * 1024 * 20;

        public AwsS3Service(IAmazonS3 s3Client, IConfiguration configuration, ILogger<AwsS3Service> logger)
        {
            _s3Client = s3Client;
            _configuration = configuration;
            _logger = logger;
            _region = _configuration["AWS:Region"];
            _bucketName = _configuration["AWS:BucketName"];
            if (_bucketName.IsNullOrEmpty())
                throw new Exception("FRZ: Invalid bucket name from config");

        }

        

        public Task<byte[]> DownloadFileAsync(string file)
        {
            throw new NotImplementedException();
        }

        public async Task<string> UploadFileAsync(IBrowserFile browserFile, Guid attachmentGuid, string s3Folder)
        {
            var bucketAddress = await CreateBucketAsync(_bucketName);
            if (bucketAddress.IsNullOrEmpty())
                throw new Exception("FRZ:Error in S3 Connection");


            try
            {
                var fileUrl = attachmentGuid.ToString("N") + Path.GetExtension(browserFile.Name);
                var fileTransferUtility = new TransferUtility(_s3Client);

                var openReadStream = browserFile.OpenReadStream(maxFileSize);
                var uploadRequest = new TransferUtilityUploadRequest
                {
                    //FilePath = path,
                    InputStream = openReadStream,
                    ContentType = browserFile.ContentType,
                    Key = fileUrl,
                    BucketName = $"{_bucketName}/{s3Folder}",
                    CannedACL = S3CannedACL.PublicRead
                }
                    .WithAutoCloseStream(true);

                await fileTransferUtility.UploadAsync(uploadRequest);

                return GetFileUrl($"{s3Folder}/{fileUrl}");
            }
            catch (Exception ex)
            {
                _logger.Error(" FRZ: Failed to upload File to S3");
                throw;
            }
        }
        public async Task<string> UploadPdfFileAsync(Stream fs, Guid attachmentGuid, string s3Folder)
        {
            var bucketAddress = await CreateBucketAsync(_bucketName);
            if (bucketAddress.IsNullOrEmpty())
                throw new Exception("FRZ:Error in S3 Connection");


            try
            {
                var fileUrl = attachmentGuid.ToString("N") + ".pdf";
                var fileTransferUtility = new TransferUtility(_s3Client);

                //            var openReadStream = fs.OpenReadStream(maxFileSize);
                var uploadRequest = new TransferUtilityUploadRequest
                {
                    //FilePath = path,
                    InputStream = fs,
                    ContentType = "application/pdf",
                    Key = fileUrl,
                    BucketName = $"{_bucketName}/{s3Folder}",
                    CannedACL = S3CannedACL.PublicRead
                }
                    .WithAutoCloseStream(true);

                await fileTransferUtility.UploadAsync(uploadRequest);

                return GetFileUrl($"{s3Folder}/{fileUrl}");
            }
            catch (Exception ex)
            {
                _logger.Error(" FRZ: Failed to upload File to S3");
                throw;
            }
        }

        string GetFileUrlAWS(string filekey)
        {
            return $"https://{_bucketName}.s3.{_region}.amazonaws.com/{filekey}";
        }

        string GetFileUrl(string filekey)
        {
            // https://s3.ir-thr-at1.arvanstorage.com
            return $"https://{_bucketName}.s3.{_region}.amazonaws.com/{filekey}";
        }


        public async Task<bool> DeleteFileAsync(string fileName)
        {
            var key = fileName.GetAfter(".amazonaws.com/");
            try
            {
                var deleteObjectRequest = new DeleteObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key
                };

                var exists = await Exists(key);
                if (exists is null)
                {
                    _logger.Warning($"File not exist in S3 bucket {_bucketName} - key {key}");
                    return false;
                }

                _logger.Warning("File removed from S3 bucket :" + key);

                var x = await _s3Client.DeleteObjectAsync(deleteObjectRequest);
            }
            catch (AmazonS3Exception e)
            {
                _logger.Error($"Error encountered on server. Message:'{e.Message}' when deleting an object");
                return false;
            }
            catch (Exception e)
            {
                _logger.Error($"Unknown encountered on server. Message:'{e.Message}' when deleting an object");
                return false;
            }

            return true;
        }

        public async Task<IEnumerable<string>> ListBuckets()
        {
            var listBucketsAsync = await _s3Client.ListBucketsAsync();
            return listBucketsAsync.Buckets.Select(x => x.BucketName);
        }


        async Task<string> CreateBucketAsync(string bucketName)
        {
            try
            {
                if (!await AmazonS3Util.DoesS3BucketExistV2Async(_s3Client, bucketName))
                {
                    var putBucketRequest = new PutBucketRequest
                    {
                        BucketName = bucketName,
                        UseClientRegion = true
                    };

                    var putBucketResponse = await _s3Client.PutBucketAsync(putBucketRequest);
                }

                // Retrieve the bucket location.
                var bucketLocation = await FindBucketLocationAsync(_s3Client, bucketName);
                return bucketLocation;
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered on server. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }

            _logger.Warning("Invalid Bucket !!!");

            return null;
        }

        async Task<string> FindBucketLocationAsync(IAmazonS3 client, string bucketName)
        {
            var request = new GetBucketLocationRequest
            {
                BucketName = bucketName
            };
            var response = await client.GetBucketLocationAsync(request);
            var bucketLocation = response.Location.ToString();
            return bucketLocation;
        }

        public async Task<string?> Exists(string fileKey)
        {
            try
            {
                _ = await _s3Client
                    .GetObjectMetadataAsync(new GetObjectMetadataRequest
                    {
                        BucketName = _bucketName,
                        Key = fileKey
                    });

                return GetFileUrl(fileKey);
            }

            catch (AmazonS3Exception ex)
            {
                if (ex.StatusCode == HttpStatusCode.NotFound)
                    return null;

                //status wasn't not found, so throw the exception
                //throw;
            }
            return null;
        }
    }
}
