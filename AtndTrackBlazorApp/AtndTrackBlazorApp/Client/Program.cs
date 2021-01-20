using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Blazored.Modal;
using AtndTrackBlazorApp.Client.Services;
using System.Net.Http;
using AtndTrackBlazorApp.Client.Helpers;

namespace AtndTrackBlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();
            builder.Services
               .AddScoped<IAccountService, AccountService>()
               .AddScoped<IAlertService, AlertService>()
               .AddScoped<IEmployeeService, EmployeeService>()
               .AddScoped<IHttpService, HttpService>()
               .AddScoped<ILocalStorageService, LocalStorageService>();
            builder.Services.AddBlazoredModal();
            // configure http client
            //builder.Services.AddScoped(x => {
            //    var apiUrl = new Uri("https://localhost:5055");

            //    //// use fake backend if "fakeBackend" is "true" in appsettings.json
            //    //if (builder.Configuration["fakeBackend"] == "true")
            //    //{
            //    var fakeBackendHandler = new FakeBackendHandler(x.GetService<ILocalStorageService>());
            //    return new HttpClient(fakeBackendHandler) { BaseAddress = apiUrl };
            //    // }

            //    return new HttpClient() { BaseAddress = apiUrl };
            //});

            var host = builder.Build();

            var accountService = host.Services.GetRequiredService<IAccountService>();
            await accountService.Initialize();

            await host.RunAsync();
        }
    }
}
