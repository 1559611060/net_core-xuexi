using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_start.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace core_start
{

    public class Startup
    {
        private readonly IConfiguration _configuration;
        /// <summary>
        /// ��ȡ�����ļ�
        /// IConfiguration���洢���������ļ���ֵ��
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            this._configuration = configuration;
            //var config = _configuration["core_start:BoldDepartmentEmployeeCountThreshold"];
        }

        // �˷���������ʱ���á�ʹ�ô˷�����������ӵ������С�
        // �й��������Ӧ�ó���ĸ�����Ϣ������� https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//��� mvc ����

            ///
            /// ����Լ��ķ��� 
            /// 1.AddSingleton:���������������� һֱ���ڣ�ֱ������ر�
            /// 2.AddTransient:����ÿ�����󶼻������µ�ʵ��
            /// 3.AddScoped:һ��web��������һ��ʵ����ֱ���������
            services.AddSingleton<IClock, UtcClock>();
            //services.AddTransient<IClock, UtcClock>();
            //services.AddScoped<IClock, UtcClock>();

            services.AddSingleton<IDepartmentSevice, DepatmentService>();
            services.AddSingleton<IEmpyloyeeService, EmployeeService>();

            //�����ļ� core_startOptions.cs ��appsettings.json
            services.Configure<core_startOptions>(_configuration.GetSection(key: "core_start"));

        }

        // �˷���������ʱ���á�ʹ�ô˷�������HTTP����ܵ���
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            ///�жϻ������� start
            if (env.IsDevelopment())//��������
            {
                app.UseDeveloperExceptionPage();//���������м��
            }
            if (env.IsProduction())//��������
            {

            }
            if (env.IsStaging())//��ʽ����
            {

            }
            if (env.IsEnvironment("OK"))//�Զ���Ļ�������
            {

            }
            ///�������� end
            ///

            //��̬�ļ��м�� 
            app.UseStaticFiles();
            //��http����ǿ�Ʊ��https �м��
            app.UseHttpsRedirection();
            //�����֤�м��
            app.UseAuthentication();

            //·���м��
            app.UseRouting();
            //�˵��м��
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Department}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
