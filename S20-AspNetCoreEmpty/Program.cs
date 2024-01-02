var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () => "Hello World!");
app.MapGet("/about-us", () => "about-us!");
app.MapGet("/contact-us", () => "contact-us!");

