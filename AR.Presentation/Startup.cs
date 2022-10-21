using AR.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace AR.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "AR.Presentation", Version = "v1" }); });

            services.AddDbContext<ContextoPrincipal>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ApiRestConnectionString")));
        }

       
















    }
}
