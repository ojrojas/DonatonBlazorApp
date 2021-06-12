using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DonatonBlazor.Configuration;
using MatBlazor;

namespace DonatonBlazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            var http = new HttpClient
            {
                BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
            };

            builder.Services.AddScoped(sp => http);
            using var response = await http.GetAsync($"appsettings.{builder.HostEnvironment.Environment}.json");
            using var appSettingsStream = await response.Content.ReadAsStreamAsync();

            builder.Configuration.AddJsonStream(appSettingsStream);

            var AppConfiguration = builder.Configuration;
            var UrlBaseConfiguration = AppConfiguration.GetSection("UrlBaseApi");

            builder.Services.Configure<DonatonConfiguration>(config => config.UrlBaseApi = UrlBaseConfiguration.Value);
            builder.Services.AddMatBlazor();

            await builder.Build().RunAsync();
        }
    }
}
