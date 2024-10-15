using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using site2024.Context;
using site2024.Models;
using site2024.Repositories;
using site2024.Repositories.Interfaces;

using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace site2024;
public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)

    {
        services.AddDbContext<AppDbcontext>(Options =>
             Options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


        services.AddTransient<ISupplementRepository, SupplementRepository>();
        services.AddTransient<ICategoryRepository, CategoryRepository>();
        services.AddTransient<IOrderRepository, OrderRepository>();

        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // com isso eu consigo recuperar uma instancia.

        services.AddScoped(sp => ShoppingCart.GetCart(sp));     // SP is an instance of the service provider (IServiceProvider).create a CART can check on shpppingCart.
                                                               

        services.AddControllersWithViews();
        //enable the Body Services cache and then I will add memory cache and  the Section services 
        services.AddMemoryCache();
        services.AddSession();

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
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        // ativacao de aplicacao
        app.UseSession();
        

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {

            endpoints.MapControllerRoute(
               name: "CategoryFilter",
            pattern: "supplement/{action}/{category}",
            defaults: new { controller = "supplement",Action = "List"});


            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });
    }
}