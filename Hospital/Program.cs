using DataBase;
using DataBase.Entities;
using DataBase.Operations;
using Hospital.Data;

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using MudBlazor.Services;

using Radzen;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddMudServices();
            builder.Services.AddRadzenComponents();
            builder.Services.AddScoped<DataBase.Operations.IDefaultOperationDbEntity<Patient>, PatientOperationService>();
            builder.Services.AddScoped<DataBase.Operations.IDefaultOperationDbEntity<MedCard>, MedCardOperationService>();
            builder.Services.AddScoped<DataBase.Operations.IDefaultOperationDbEntity<Genre>, GenreOperationService>();
            builder.Services.AddScoped<DataBase.Operations.IDefaultOperationDbEntity<InsurancePolicy>, InsuranceOperationService>();
            builder.Services.AddScoped<DataBase.Operations.IDefaultOperationDbEntity<Genre>, GenreOperationService>();
            builder.Services.AddDbContext<Context>();
            builder.Services.AddSingleton<Services.Notification.NotificationService>();
            var app = builder.Build();

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

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
