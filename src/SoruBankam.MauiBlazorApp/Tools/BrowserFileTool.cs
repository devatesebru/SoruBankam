using Microsoft.AspNetCore.Components.Forms;
using SoruBankam.WebCommons.Tools;

namespace SoruBankam.MauiBlazorApp.Tools
{
    public class BrowserFileTool : IBrowserFileTool
    {
        public async Task<string> ToBase64(IBrowserFile browserFile)
        {
            if (browserFile.Size > 10_000_000)
                throw new Exception("Image size then 10.000.000 byte!");

            IBrowserFile imgFile = browserFile;
            var buffers = new byte[imgFile.Size];
            await imgFile.OpenReadStream().ReadAsync(buffers);
            string imageType = imgFile.ContentType;
            return $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        }

        public async Task<string> TakePhotoAndConvertBase64()
        {
            if (MediaPicker.Default.IsCaptureSupported)
            {
                FileResult photo = await MediaPicker.Default.CapturePhotoAsync();

                return await ToBase64(photo);
            }

            throw new Exception("Not Is Capture Supported!");
        }

        private async Task<string> ToBase64(FileResult photo)
        {
            if (photo == null)
                throw new Exception("Fotoğraf bulunamadı!");

            using Stream sourceStream = await photo.OpenReadAsync();
            byte[] buffer = new byte[sourceStream.Length];
            sourceStream.Read(buffer, 0, buffer.Count());

            return await Task.FromResult($"data:{photo.ContentType};base64,{Convert.ToBase64String(buffer)}");
        }
    }
}
