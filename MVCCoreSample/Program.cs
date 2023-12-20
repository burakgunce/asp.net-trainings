namespace MVCCoreSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //mvc moduunun yuklend�g� k�s�m
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();//http �stekler�n� https yonlend�rmes� yapar
            app.UseStaticFiles();//wwwroot alt�ndak� stat�c dosyalar�n kullan�lmas�n� sagla
            //(cl�ent s�de kutuphaneler�n� kulanmaya �z�n ver�r)

            app.UseRouting();

            app.UseAuthorization();//yetk�lend�rme varsa bu uygulamada kullan�m�na �z�n ver�r

            app.UseStatusCodePages();//http durumu 200 ok 400 bad request bunlar� gormek �c�n
            //(400 ile 599 aras�ndaym�s ustekk� tam dogru deg�l)

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}