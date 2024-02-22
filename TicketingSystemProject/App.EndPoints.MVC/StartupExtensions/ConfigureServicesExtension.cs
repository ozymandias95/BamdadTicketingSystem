using App.Domain.Core.Tickets.Data.RepositoriesContract;
using App.Domain.Core.Tickets.ServicesContracts;
using App.Domain.Core.Users.Data.UserRepositoriesContract;
using App.Domain.Core.Users.ServicesContracts;
using App.Domain.Services.Tickets;
using App.Domain.Services.Users;
using App.Infra.Data.Db.SqlServer.Ef.DbCtx;
using App.Infra.Data.Repos.Ef.Tickets;
using App.Infra.Data.Repos.Ef.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StartupExtensions
{
    public static class ConfigureServicesExtension
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            var config = (ConfigurationManager)configuration;
            config.SetBasePath(Directory.GetCurrentDirectory())
            .AddUserSecrets("8715b531-296d-43e5-9f8f-307ab3132538");


            services.AddScoped<ITicketCommandRepository, TicketCommandRepository>();
            services.AddScoped<ITicketQueryRepository, TicketQueryRepository>();
            services.AddScoped<IAppUserCommandRepository, AppUserCommandRepository>();
            services.AddScoped<IAppUserQueryRepository, AppUserQueryRepository>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ITicketServices, TicketServices>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            // services.AddRazorPages();
            services.AddDbContext<AppDbContext>(option => option.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }));
            //services.AddAuthentication("MyClaim").AddCookie("MyClaim", configureOptions =>
            //{
            //    configureOptions.Cookie.Name = "MyClaim";
            //});

            services.AddIdentity<ApplicationUser, ApplicationRole>(option =>
                    {
                        option.Password.RequiredLength = 8;
                        option.Password.RequireDigit = true;
                        option.Password.RequireUppercase = true;
                        option.Password.RequireLowercase = true;
                        option.Password.RequireNonAlphanumeric = true;
                        option.User.RequireUniqueEmail = true;
                    }
                    )
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders()
                .AddUserStore<UserStore<ApplicationUser, ApplicationRole, AppDbContext, int>>()
                .AddRoleStore<RoleStore<ApplicationRole, AppDbContext, int>>();
        }
    }
}
