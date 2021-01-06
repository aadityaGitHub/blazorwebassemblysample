using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using DataAccess.Repositories;
using MediatR;
using AtndTrackBlazorApp.Server.Commands;
using AtndTrackBlazorApp.Shared.Models;
using AutoMapper;
using DataAccess;
using AtndTrackBlazorApp.Shared;
using AtndTrackBlazorApp.Server.Services;

namespace AtndTrackBlazorApp.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews();
            services.AddDbContext<AttendancetrackContext>(options =>
            {
                options.UseSqlServer(Configuration.GetValue<string>("ConnectionStrings:ConnectionString"));
            });
            services.AddScoped<IOrganizationRepo, OrganizationRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<ILeaveRequestRepo, LeaveRequestRepo>();
            services.AddScoped<IUserRepo, UserRepo>();
            services.Configure<SmtpServerSetting>(Configuration.GetSection("SmtpServerSettings"));
            services.AddScoped<IEmailService, EmailService>();
            services.AddMediatR(typeof(DepartmentCommand).Assembly);
            services.AddAutoMapper(typeof(MappingConfig));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
