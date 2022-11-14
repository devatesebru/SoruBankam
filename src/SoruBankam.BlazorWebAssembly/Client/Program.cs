using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using SoruBankam.BlazorWebAssembly;
using SoruBankam.BlazorWebAssembly.Tools;
using SoruBankam.Business.Abstract;
using SoruBankam.Business.Concrete;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.DataAccessLayer.Concrete.SQLiteNet;
using SoruBankam.WebCommons.Tools;

namespace SoruBankam.BlazorWebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddMudServices();
            builder.Services.AddSingleton<IQuestionManager, QuestionManager>();
            builder.Services.AddSingleton<IQuestionRepository, QuestionRepository>();
            builder.Services.AddSingleton<ITagManager, TagManager>();
            builder.Services.AddSingleton<ITagRepository, TagRepository>();
            builder.Services.AddSingleton<IBrowserFileTool, BrowserFileTool>();

            await builder.Build().RunAsync();
        }
    }
}