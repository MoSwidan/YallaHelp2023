using Blazor.SubtleCrypto;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using YallaHelp2023;
using YallaHelp2023.AppService;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var configuration = builder.Configuration.Build();
var Api = configuration.GetConnectionString("ApiConnection");

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri($"{Api}") });
builder.Services.AddScoped<MainService>();
builder.Services.AddScoped<AlertService>();
builder.Services.AddSubtleCrypto(opt =>
	opt.Key = "ELE9xOyAyJHCsIPLMbbZHQ7pVy7WUlvZ60y5WkKDGMSw5xh5IM54kUPlycKmHF9VGtYUilglL8iePLwe" //Use another key
);
builder.Services.AddBlazoredLocalStorage();
await builder.Build().RunAsync();
