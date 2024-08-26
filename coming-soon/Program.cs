var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve the "Coming Soon" HTML page when the root URL is accessed
app.MapGet("/", async context =>
{
    context.Response.ContentType = "text/html";
    await context.Response.SendFileAsync("wwwroot/coming-soon.html");
});

app.Run();
