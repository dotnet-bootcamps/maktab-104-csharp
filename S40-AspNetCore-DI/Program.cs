using S40_AspNetCore_DI.Contracts;
using S40_AspNetCore_DI.Domain;
using S40_AspNetCore_DI.Infrastructures;
using S40_AspNetCore_DI.Models.LifeTimeDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddSingleton<MessageCreator>();
builder.Services.AddScoped<MessageCreator>();
//builder.Services.AddTransient<MessageCreator>();


// Concrete
//builder.Services.AddScoped<StudentInMemoryRepository>();
//builder.Services.AddScoped<StudentEfRepository>();

// Contract
//builder.Services.AddScoped<IStudentRepository, StudentInMemoryRepository>();
builder.Services.AddScoped<IStudentRepository, StudentEfRepository>();


builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddTransient<ITransientService, TransientService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=GetWelcomeMessage}/{id?}");

app.Run();
