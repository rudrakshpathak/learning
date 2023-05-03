using ASP_WebAPI;
using ASP_WebAPI.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<DatabaseConnection>();

var app = builder.Build();

//app.UseMiddleware<SampleMiddleware>();
app.UseSampleMiddleware();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<AuthorizationMiddleware>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();

