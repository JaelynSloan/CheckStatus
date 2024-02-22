using CheckStatus.Web;
using CheckStatus.Web.Services;
using CheckStatus.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7236/") });

builder.Services.AddScoped<ICheckStatusService, CheckStatusService>();

await builder.Build().RunAsync();
