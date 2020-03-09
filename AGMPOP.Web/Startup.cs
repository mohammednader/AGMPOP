using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AGMPOP.BL;
using AGMPOP.BL.CoreBL;
using AGMPOP.BL.CoreBL.IRepositories;
using AGMPOP.BL.Models.Domain;
using AGMPOP.BL.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AGMPOP.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie();

            var connection = Configuration.GetConnectionString("AGMPOPContext") ??
                 "Server=.;Database=AGMPOP;Trusted_Connection=True;";

            services.AddDbContextPool<AGMPOPContext>(options => options.UseSqlServer(connection));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IJobTitleRepository, JobTitleRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<ITerritoriesRepository, TerritoriesRepository>();
            services.AddScoped<ICycleUserRepository, CycleUserRepository>();
            services.AddScoped<ICycleProductRepository, CycleProductRepository>();
            services.AddScoped<ICyclesRepository, CyclesRepository>();
            services.AddScoped<IRequestsRepository, RequestsRepository>();
            services.AddScoped<ITransactionDetailsRepository, TransactionDetailsRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<IInventoryLogRepository, InventoryLogRepository>();
            services.AddScoped<INotificationsRepository, NotificationsRepository>();
            services.AddScoped<IUserClearanceRepository, UserClearanceRepository>();
            services.AddScoped<IAuditRepository, AuditRepository>();

            services.AddSignalR(options => {
                options.KeepAliveInterval = TimeSpan.FromMinutes(1);
            });
            services.AddSingleton<Notify>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSignalR(routes =>
            {
                routes.MapHub<Notify>("/Notify");
            });
        }
    }
}
