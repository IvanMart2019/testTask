using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using testTask.Data;
using testTask.Data.interfaces;
using testTask.Data.mocks;

namespace testTask
{
    public class Startup
    {
       private IConfigurationRoot _confString;

       public Startup(IHostingEnvironment hostEnv)
       {
            _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
            /*
             * _confString читаю данные из созданного мной конфигурационного файла dbsettings.json, Build() значит сохранить его данные в _confString
             */
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // указываю какой использовать sql сервер
            services.AddDbContext<AppDBContent>(option => option.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

            services.AddTransient<IProducts, MockProduct>();
            services.AddTransient<IProductsCategorys, MockCategory>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();// в случае если будет неизвестный путь то будет загружен дефолтный роут
            
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
            
               app.Run(async (context) =>
                {
                   // await context.Response.WriteAsync("Hello World!");
                });
            
        }
    }
}
