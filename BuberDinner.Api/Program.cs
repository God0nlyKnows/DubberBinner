using BuberDinner.Api;
using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    //builder.Services.AddControllers(x=> x.Filters.Add<ErrorHandlingFilterAttribute>());

    builder.Services.AddPresentation();
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure(builder.Configuration);
}

var app = builder.Build();
{
    //app.UseMiddleware<ErrorHandlingMiddleware>();
    app.UseExceptionHandler("/error");
    app.UseAuthentication();
    app.UseAuthorization();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

