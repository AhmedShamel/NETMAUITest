using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace EClinicMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();

         


#if DEBUG
            builder.Logging.AddDebug();
#endif
            
            //builder.Services.AddSingleton<MainPage>(provider => new MainPage(provider.GetRequiredService<MyDevice>()));
            return builder.Build();
        }
    }
}