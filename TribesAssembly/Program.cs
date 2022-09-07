using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TribesAssembly;
using Refit;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddRefitClient<IDatabaseQuery>().ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:7230/api"));

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<ServerConnection>();
builder.Services.AddSingleton<PersistentData>();
builder.Services.AddScoped<DesignHelper>();


await builder.Build().RunAsync();
