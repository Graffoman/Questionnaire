using Front;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Newtonsoft.Json;
using Front.Automapper;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5239/api/") });
builder.Services.AddBlazorBootstrap();
builder.Services.AddSingleton(sp => new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
builder.Services.InstallAutomapper();

await builder.Build().RunAsync();
