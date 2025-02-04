using TestCaseElevator.Business.Validations;
using TestCaseElevator.Business.Interfaces;
using TestCaseElevator.Business.Classes;
using TestCaseElevator.Business.Operations;
using System.Reflection;
using TestCaseElevator.Services.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
    
builder.Services.AddTransient<Validator>()
    .AddTransient<Operator>()
    .AddTransient<IElevatorIndoorController, ElevatorIndoorController>()
    .AddTransient<IElevatorOutdoorController, ElevatorOutdoorController>()
    .AddScoped<ElevatorIndoor>()
    .AddScoped<ElevatorOutdoor>()
    .AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));


    var app = builder.Build();

//app.Services.AddSingleton<IElevatorIndoorController, ElevatorIndoorController>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapRazorPages();

app.Run();
