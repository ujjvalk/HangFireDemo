using Hangfire;

namespace HangFireDemo
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddHangfire(x =>
            {
                x.UseSqlServerStorage(configuration.GetConnectionString("DBConnection"));
            });
            services.AddHangfireServer();
        }
    }
}
