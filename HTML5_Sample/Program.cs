namespace HTML5_Sample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            DefaultFilesOptions options = new DefaultFilesOptions();
            /*
             * Index.html
             * Index.htm
             * Default.html
             * Default.htm
             */
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("Index.html");
            app.UseDefaultFiles(options);

            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}