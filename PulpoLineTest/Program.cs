using DataService;
using Core;
using Core.Context;
using Microsoft.EntityFrameworkCore;
using PulpoLineTest.Filte;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DbCoreContext>(options =>     options.UseInMemoryDatabase("MemoryDataBase"));
builder.Services.InitializerDataService();
builder.Services.InitializerCoreDataService();
builder.Services.AddControllers(options => { options.Filters.Add<LoggingActionFilter>();});
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DbCoreContext>();
    dbContext.Seeder();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
