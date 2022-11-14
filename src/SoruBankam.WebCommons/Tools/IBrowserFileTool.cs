using Microsoft.AspNetCore.Components.Forms;

namespace SoruBankam.WebCommons.Tools;

public interface IBrowserFileTool
{
    public Task<string> TakePhotoAndConvertBase64();
    public Task<string> ToBase64(IBrowserFile browserFile);
}
