using ChatApp.HubOperation.Hubs;

namespace ChatApp.HubOperation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddSignalR();

            builder.Services.AddCors(setup =>
            {

                setup.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials()
                    .SetIsOriginAllowed(orgin => true);

                });

            });
            var app = builder.Build();

            app.UseCors();
            app.MapHub<ChatHub>("/chatHub");

            app.Run();
        }
    }
}
