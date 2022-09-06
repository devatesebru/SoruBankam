using Microsoft.AspNetCore.Components.WebView.Maui;
using SoruBankam.Business.Abstract;
using SoruBankam.Business.Concrete;
using SoruBankam.DataAccessLayer.Abstract;
using SoruBankam.DataAccessLayer.Concrete.SQLiteNet;
using MudBlazor.Services;
using SoruBankam.MauiBlazorApp;

namespace SoruBankam.MauiBlazorApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddMudServices();
            builder.Services.AddSingleton<IQuestionManager, QuestionManager>();
            builder.Services.AddSingleton<IQuestionRepository, QuestionRepository>();
          

            return builder.Build();
        }
    }
}