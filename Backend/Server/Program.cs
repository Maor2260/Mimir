using Hub;
using Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.SetupDependencyInjections();
builder.Services.SetupDataContext();
builder.Services.AddControllers();
builder.Services.AddSignalR();
builder.Services.SetupCors();
builder.Services.SetupSwagger();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.SetupSwagger();
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapHub<GameHub>("/hub");

app.Run();