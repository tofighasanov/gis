using Syncfusion.Licensing;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем лицензию
SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JFaF5cXGRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWH5edXRTRWFYVkB2WEVWYEg=");

// стандартная настройка MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// остальные стандартные middlewares
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
