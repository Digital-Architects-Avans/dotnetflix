using dotnetflix.Api.Data;
using dotnetflix.Api.Repositories.Contracts;
using dotnetflix.Api.Repositories.Movies;
using dotnetflix.Api.Repositories.Orders;
using dotnetflix.Api.Repositories.Seats;
using dotnetflix.Api.Repositories.Shows;
using dotnetflix.Api.Repositories.Supplements;
using dotnetflix.Api.Repositories.TheaterRows;
using dotnetflix.Api.Repositories.Theaters;
using dotnetflix.Api.Repositories.Tickets;
using dotnetflix.Api.Repositories.TicketSupplements;
using dotnetflix.Api.Repositories.TicketTypes;
using dotnetflix.Api.Services;
using dotnetflix.Api.Services.Contracts;
using dotnetflix.Web.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DotNetFlixDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IShowRepository, ShowRepository>();
builder.Services.AddScoped<ITheaterRowRepository, TheaterRowRepository>();
builder.Services.AddScoped<ITheaterRepository, TheaterRepository>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<ITicketTypeRepository, TicketTypeRepository>();
builder.Services.AddScoped<ISeatRepository, SeatRepository>();
builder.Services.AddScoped<IPayPalService, PayPalService>();
builder.Services.AddScoped<ISupplementRepository, SupplementRepository>();
builder.Services.AddScoped<ITicketSupplementRepository, TicketSupplementRepository>();

builder.Services.AddHttpClient("PayPalSandBoxHttpClient", client =>
{
    client.BaseAddress = new Uri("https://api-m.sandbox.paypal.com/");
});

builder.Services.Configure<PayPalSettings>(builder.Configuration.GetSection("PayPalSettings"));

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:5194")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors(policy =>
    policy.WithOrigins("http://localhost:5106", "https://localhost:7257")
        .AllowAnyMethod()
        .WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

// Use CORS policy
app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();
app.MapControllers();

app.Run();