using dotnetflix.Web;
using dotnetflix.Web.Services;
using dotnetflix.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7100/") });
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:7000/") });

// Register services
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IShowService, ShowService>();

await builder.Build().RunAsync();
