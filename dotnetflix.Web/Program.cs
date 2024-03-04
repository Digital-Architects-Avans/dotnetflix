using dotnetflix.Web;
using dotnetflix.Web.Services;
using dotnetflix.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7100/") });

// Register services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IShowService, ShowService>();
builder.Services.AddScoped<ITicketService, TicketService>();

await builder.Build().RunAsync();