namespace MVCCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //mvc moduunun yuklendýgý kýsým
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();//http ýsteklerýný https yonlendýrmesý yapar
            app.UseStaticFiles();//wwwroot altýndaký statýc dosyalarýn kullanýlmasýný sagla
            //(clýent sýde kutuphanelerýný kulanmaya ýzýn verýr)

            app.UseRouting();

            app.UseAuthorization();//yetkýlendýrme varsa bu uygulamada kullanýmýna ýzýn verýr

            app.UseStatusCodePages();//http durumu 200 ok 400 bad request bunlarý gormek ýcýn
            //(400 ile 599 arasýndaymýs ustekký tam dogru degýl)

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}