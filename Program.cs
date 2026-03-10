using AppGenealogySystem.Context;
using AppGenealogySystem.Service;
using AppGenealogySystem.State;
using AppGenealogySystem.UC;
using AppGenealogySystem.Ui.Bom;
using AppGenealogySystem.Ui.Product;
using AppGenealogySystem.Ui.WOUi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Windows.Interop;
// Khởi tạo linq2db cho EF Core

namespace AppGenealogySystem
{
    internal static class Program
    {
        // Thêm biến này để lưu trữ bộ máy DI
        public static IServiceProvider? ServiceProvider { get; private set; }
        private static readonly object _logLock = new object();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Khởi tạo danh sách dịch vụ
            var services = new ServiceCollection();
            ConfigureServices(services);
            // 2. Xây dựng ServiceProvider từ danh sách đã đăng ký
            ServiceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();


            // 3. QUAN TRỌNG: Lấy Form1 từ DI Container chứ không dùng "new Form1()"
            var mainForm = ServiceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();
            var logFilePath = Logger.getRelativePath("sql_query.log");

            var fs = new FileStream(logFilePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            using var writer = new StreamWriter(fs);

            var connectionString =
                configuration.GetConnectionString("DefaultConnection");
            // Cấu hình MySQL với Factory
            //string connectionString = "server=localhost;port=3306;user=root;password=123456;database=project_app;";
            services.AddPooledDbContextFactory<AppDBContext>(opt =>
                opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
                .LogTo(msg =>
                {
                    lock (_logLock)
                    {
                        File.AppendAllText(Logger.getRelativePath("sql_query.log"), msg + Environment.NewLine);
                    }

                }));
            // Đăng ký Service chung
            services.AddScoped<IDataService, DataService>();
            services.AddScoped<IBomService, BomService>();
            services.AddSingleton<BomState>();
            services.AddTransient<UcGenealogyQuery>();
            services.AddTransient<SupplierControl>();
            services.AddTransient<UCBomList>();
            services.AddTransient<UcProductionEx>();
            services.AddTransient<UcLotReceiving>();
            services.AddTransient<UcTraceForward>();
            services.AddTransient<UCProductList>();
            services.AddTransient<UCWorkOrder>();
            // Đăng ký các Form vào hệ thống DI
            services.AddTransient<Form1>();
            services.AddTransient<BomForm>();
            services.AddTransient<WOForm>();
            services.AddTransient<ProductForm>();
            services.AddTransient<ProductFormLookup>();
            services.AddTransient<LookupProduct>();
        }
    }
}