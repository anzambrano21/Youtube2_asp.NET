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
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
//enrutamiento especial 
app.MapControllerRoute(
    name: "Canal",
    pattern: "Canal/{v?}",
    defaults: new { controller = "Home", action = "Perfil" });
app.MapControllerRoute(
    name: "watchVideo",
    pattern: "Video/{v?}",
    defaults: new { controller = "Home", action = "Video" });
app.MapControllerRoute(
    name: "Buscar",
    pattern: "Result/{v?}",
    defaults: new { controller = "Home", action = "Buscar" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
