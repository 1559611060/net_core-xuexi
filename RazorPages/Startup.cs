using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RazorPages.Service;

namespace RazorPages
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// 获取配置文件
        /// IConfiguration：存储的是配置文件键值对
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
            //var config = _configuration["core_start:BoldDepartmentEmployeeCountThreshold"];
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();//添加 RazorPages 服务

            ///
            /// 添加自己的服务 
            /// 1.AddSingleton:服务类型生命周期 一直存在，直到程序关闭
            /// 2.AddTransient:服务每次请求都会生成新的实例
            /// 3.AddScoped:一次web请求生成一次实例，直到请求完毕
            services.AddSingleton<IClock, UtcClock>();
            //services.AddTransient<IClock, UtcClock>();
            //services.AddScoped<IClock, UtcClock>();

            services.AddSingleton<IDepartmentSevice, DepatmentService>();
            services.AddSingleton<IEmpyloyeeService, EmployeeService>();

            //配置文件 core_startOptions.cs 、appsettings.json
            services.Configure<RazorPagesOptions>(_configuration.GetSection(key: "core_start"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ///判断环境变量 start
            if (env.IsDevelopment())//开发环境
            {
                app.UseDeveloperExceptionPage();//错误详情中间件
            }
            if (env.IsProduction())//生产环境
            {

            }
            if (env.IsStaging())//正式环境
            {

            }
            if (env.IsEnvironment("OK"))//自定义的环境变量
            {

            }
            ///环境变量 end
            ///

            //静态文件中间件 
            app.UseStaticFiles();
            //把http请求强制变成https 中间件
            app.UseHttpsRedirection();
            //身份认证中间件
            app.UseAuthentication();

            //路由中间件
            app.UseRouting();
            //端点中间件
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapRazorPages();
            });
        }
    }
}
