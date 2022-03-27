using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace BackAplicacion
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            DTOs.AutoMapperConfiguration.Configure();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public Startup(IConfiguration configuration)
        {
       
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddJsonOptions(options =>
                options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddDbContext<Models.StoreDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("StoreDBContext")));
        }
    }
}
