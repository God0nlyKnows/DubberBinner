using BuberDinner.Api;
using BuberDinner.Application;

var builder = WebApplication.CreateBuilder(args);
{
builder.Services.AddEndpointsApiExplorer();

    builder.Services
        .AddPresentation()
        .AddApplication();
}

var app = builder.Build();
{
    
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler("/error");
app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
}

