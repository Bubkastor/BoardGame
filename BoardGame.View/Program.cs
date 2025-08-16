using BoardGame.Extensions.Options;
using BoardGame.View.Config;
using BoardGame.View.Services;

namespace BoardGame.View;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();
       
        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor()
            .AddInteractiveServerComponents();
        builder.Services.AddHttpClient();
        builder.Services.AddScoped<BrowserStorageService>();
        
        builder.Services.AddOptions<SettingsApi>().BindAndValidateDataAnnotationsOnStartRecursively(builder.Configuration.GetSection("Api"));
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        else
        {
            app.UseHttpsRedirection();
        }

        app.UseStaticFiles();
        app.UseRouting();
        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}
