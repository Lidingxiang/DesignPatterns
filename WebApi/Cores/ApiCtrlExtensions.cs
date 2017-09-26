using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Http;



namespace WebApi.Cores
{
    public class ApiCtrlExtensions
    {
        public async Task<string> UploadFiles(ApiController apiController, string allowExtensions = null)
        {
            if (!apiController.Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = new MultipartMemoryStreamProvider();
            await apiController.Request.Content.ReadAsMultipartAsync(provider);

            if (provider.Contents.Count == 0)
                throw new InvalidOperationException("未发现文件流");

            if (provider.Contents.Count > 1)
                throw new InvalidOperationException("不支持同时上传多文件");


            var oldFileName = provider.Contents[0].Headers.ContentDisposition.FileName.Replace("\"", string.Empty);

            if (!string.IsNullOrEmpty(allowExtensions))
            {
                var extension = Path.GetExtension(oldFileName);

                if (string.IsNullOrEmpty(extension))
                    throw new InvalidOperationException("无法获取上传文件的扩展名");

                if (!Regex.IsMatch(extension, allowExtensions))
                    throw new InvalidOperationException("上传文件功能不支持此类型的文件");
            }
            var bytes = await provider.Contents[0].ReadAsByteArrayAsync();
            var fileName = _fileSystem.UploadWithFileName(bytes, oldFileName);
            return fileName;
        }

        public async Task<Tuple<string, string>> UploadImgReThumbJpg(ApiController apiController,string allowExtensions = null)
        {
            if (!apiController.Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = new MultipartMemoryStreamProvider();
            await apiController.Request.Content.ReadAsMultipartAsync(provider);

            if (provider.Contents.Count == 0)
                throw new InvalidOperationException("未发现文件流");

            if (provider.Contents.Count > 1)
                throw new InvalidOperationException("不支持同时上传多文件");

            var oldFileName = provider.Contents[0].Headers.ContentDisposition.FileName.Replace("\"", string.Empty);

            if (!string.IsNullOrEmpty(allowExtensions))
            {
                var extension = Path.GetExtension(oldFileName);

                if (string.IsNullOrEmpty(extension))
                    throw new InvalidOperationException("无法获取上传文件的扩展名");

                if (!Regex.IsMatch(extension, allowExtensions))
                    throw new InvalidOperationException("上传文件功能不支持此类型的文件");
            }
            var bytes = await provider.Contents[0].ReadAsByteArrayAsync();
            var originalFileName = _fileSystem.UploadWithFileName(bytes, oldFileName);

            string compressFileName;
            using (var fileStream = new MemoryStream())
            {
                using (var initImage = Image.FromStream(await provider.Contents[0].ReadAsStreamAsync()))
                {
                    var temSize = new Size(initImage.Width, initImage.Height);
                    //新建一个bmp图片
                    int imgWidth = 150, imgHeight = 200;
                    if (temSize.Width > imgHeight || temSize.Width > imgWidth)
                    {
                        if ((temSize.Width * imgHeight) > (temSize.Height * imgWidth))
                            imgHeight = (imgWidth * temSize.Height) / temSize.Width;
                        else
                            imgWidth = (temSize.Width * imgHeight) / temSize.Height;
                        using (Image newImage = new Bitmap(imgWidth, imgHeight))
                        {
                            //新建一个画板
                            using (var newG = Graphics.FromImage(newImage))
                            {
                                //设置质量
                                newG.CompositingQuality = CompositingQuality.HighQuality;
                                newG.SmoothingMode = SmoothingMode.HighQuality;
                                newG.InterpolationMode = InterpolationMode.HighQualityBicubic;
                                //置背景色
                                newG.Clear(Color.WhiteSmoke);
                                //画图
                                newG.DrawImage(initImage, new Rectangle(0, 0, newImage.Width, newImage.Height), new Rectangle(0, 0, initImage.Width, initImage.Height), GraphicsUnit.Pixel);
                                //设置压缩的比例1-100
                                ImageCodecInfo codecInfo = GetEncoderInfo();
                                var myEncoderParameters = new EncoderParameters(1);
                                myEncoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 50L);
                                //将图片流写入内存流中
                                newImage.Save(fileStream, codecInfo, myEncoderParameters);

                                compressFileName = _fileSystem.UploadWithFileName(fileStream.ToArray(), oldFileName);
                            }
                        }
                    }
                    else
                    {
                        initImage.Save(fileStream, initImage.RawFormat);
                        compressFileName = _fileSystem.UploadWithFileName(fileStream.ToArray(), oldFileName);
                    }
                }
            }
            return Tuple.Create(originalFileName, compressFileName);
        }

        private static ImageCodecInfo GetEncoderInfo()
        {
            var encoders = ImageCodecInfo.GetImageEncoders();
            return encoders.FirstOrDefault(t => t.FormatDescription.Equals("JPEG"));
        }
    }
}