using ApexCharts;
using Microsoft.Extensions.Logging;
using plot_those_lines.Services;

namespace plot_those_lines
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
            builder.Services.AddApexChartsMaui();
            builder.Services.AddScoped<DateFilter>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
