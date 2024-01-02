
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/aboutus", () => "about-us!");
            app.MapGet("/contactus", () => "contact-us!");

            app.Run();
