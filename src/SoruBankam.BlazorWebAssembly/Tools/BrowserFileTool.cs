using Microsoft.AspNetCore.Components.Forms;
using SoruBankam.WebCommons.Tools;

namespace SoruBankam.BlazorWebAssembly.Tools
{
    public class BrowserFileTool : IBrowserFileTool
    {
        public Task<string> TakePhotoAndConvertBase64()
        {
            throw new NotImplementedException();
        }

        public Task<string> ToBase64(IBrowserFile browserFile)
        {
            throw new NotImplementedException();
        }
    }
}
