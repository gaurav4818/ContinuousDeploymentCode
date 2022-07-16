var builder = WebApplication.CreateBuilder(args);
var connectionString = "Endpoint=https://appconfig9009.azconfig.io;Id=Yd8n-lh-s0:OSvWr79RTAWgfAi0QZ/S;Secret=Uh3U2Io2Oy3AB+t0X8CU5d84fTWPHtZn7i+goiD01C0=";
// Add services to the container.
builder.Host.ConfigureAppConfiguration(builder =>
{
    //Connect to your App Config Store using the connection string
    builder.AddAzureAppConfiguration(connectionString);
})
            .ConfigureServices(services =>
            {
                services.AddControllersWithViews();
            });

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

app.Run();
