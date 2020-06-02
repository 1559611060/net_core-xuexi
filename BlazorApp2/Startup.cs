using System;
using BlazorApp2.Data;
using BlazorApp2.Service;
using GRpcApi;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BlazorApp2
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
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            services.AddSingleton<IDepartmentSevice, DepatmentService>();
            services.AddSingleton<IEmpyloyeeService, EmployeeService>();
            //���grpc�ͻ��˷���  
            services
                .AddGrpcClient<Deparments.DeparmentsClient>
                (o => o.Address = new Uri("https://localhost:5201/"));//�����ַ��gRPC������������ĵ�ַ
            services
                .AddGrpcClient<Employees.EmployeesClient>
                (o => o.Address = new Uri("https://localhost:5201/"));
            //gRPC ʹ�õ��ǡ�http/2�����䣬����ͦ�鷳�ģ����������Բ���Ҫ��http/2������
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport",true);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");//Ӧ�ÿ�ʼ����_Hostҳ��
            });
        }
    }
}
