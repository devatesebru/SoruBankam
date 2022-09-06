using Microsoft.AspNetCore.Components.Forms;

namespace SoruBankam.MauiBlazorApp.Tools
{
    public static class BrowserFileTool
    {
        public async static Task<string> ToBase64(IBrowserFile browserFile)
        {
            if (browserFile.Size > 10_000_000)
                throw new Exception("Image size then 10.000.000 byte!");

            IBrowserFile imgFile = browserFile;
            var buffers = new byte[imgFile.Size];
            await imgFile.OpenReadStream().ReadAsync(buffers);
            string imageType = imgFile.ContentType;
            return $"data:{imageType};base64,{Convert.ToBase64String(buffers)}";
        }
    }
}
