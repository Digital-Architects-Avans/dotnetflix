using dotnetflix.Api.Services;
using dotnetflix.Api.Services.Contracts;
using dotnetflix.Web;
using dotnetflix.Web.Pages.Auth;
using dotnetflix.Web.Services;
using dotnetflix.Web.Services.Contracts;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7100/") });

// Register services
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IMovieService, MovieService>();
builder.Services.AddScoped<IShowService, ShowService>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderStateService, OrderStateService>();
builder.Services.AddScoped<ISeatService, SeatService>();
builder.Services.AddScoped<ITrustpilotService, MockTrustpilotService>();

builder.Services.AddFluentUIComponents();
builder.Services.AddDataGridEntityFrameworkAdapter();

builder.Services.AddOidcAuthentication(options =>
{
    builder.Configuration.Bind("Auth0", options.ProviderOptions);
    options.ProviderOptions.ResponseType = "code";
}).AddAccountClaimsPrincipalFactory<CustomUserFactory<RemoteUserAccount>>();

await builder.Build().RunAsync();