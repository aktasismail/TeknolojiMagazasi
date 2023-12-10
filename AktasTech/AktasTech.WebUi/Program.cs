using AktasTech.Business.Abstract;
using AktasTech.Business.Concrete;
using AktasTech.DataAccess.Abstract;
using AktasTech.DataAccess.Concrete;
using AktasTech.WebUi.Services.Abstract;
using AktasTech.WebUi.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddMvc();
builder.Services.AddSession();
builder.Services.AddScoped<IUrunlerService, UrunlerManager>();
builder.Services.AddScoped<IUrunlerDAL, EfUrunlerDAL>();
builder.Services.AddScoped<IKategoriService, KategorilerManager>();
builder.Services.AddScoped<IKategorilerDAL, EfKategorilerDal>();
builder.Services.AddSingleton<ISepetSessionService, SepetSessionService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<ISepetService, SepetService>();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}
app.UseHttpsRedirection();
StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
app.UseSession();
app.UseStaticFiles();
app.UseFileServer();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Urunler}/{action=Urun}/{id?}");

app.Run();
