using App.Infra.Data.Db.SqlServer.Ef.DbCtx;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StartupExtensions
{
    public static class ConfigureServicesExtension
    {
        public static void ConfigureServices(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddAuthentication("MyClaim").AddCookie("MyClaim", configureOptions =>
            //{
            //    configureOptions.Cookie.Name = "MyClaim";
            //});

            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, AppDbContext, int>>()
                .AddRoleStore<RoleStore<ApplicationRole, AppDbContext, int>>();
        }
    }
}
