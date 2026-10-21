namespace CharityStreamSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            // This enables serving static files like index.html from wwwroot
            app.UseStaticFiles();

            // This redirects the root URL ("/") straight to your index.html page
            app.MapGet("/", async context =>
            {
                context.Response.Redirect("/index.html");
                await Task.CompletedTask;
            });

            app.Run();
        }
    }
}