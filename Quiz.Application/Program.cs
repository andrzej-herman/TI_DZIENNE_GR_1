using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Quiz.Application;
using Quiz.Application.Endpoints;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IGame, Game>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7000") });

await builder.Build().RunAsync();
