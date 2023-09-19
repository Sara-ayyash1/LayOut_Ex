var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();


app.MapControllerRoute
    (
      "Default","{area=admin}/{controller=admin}/{action=login}"
    );

app.MapControllerRoute
    (
      "Default", "{controller=Home}/{action=index}"
    );
app.UseStaticFiles();

app.Run();
