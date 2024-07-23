var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "home",
//    pattern: "{action=Index}",
//    defaults: new { controller = "Home" });

//app.MapControllerRoute(
//    name: "blog",
//    pattern: "blog/{action=Blog}");

//app.MapControllerRoute(
//    name: "shop",
//    pattern: "shop/{action=ShopGrid}");

app.MapControllerRoute(
    name: "catchall",
    pattern: "{*url}",
    defaults: new { controller = "Home", action = "Error" });


app.Run();
