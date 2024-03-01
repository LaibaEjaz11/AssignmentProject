using Microsoft.EntityFrameworkCore;
using UserManagement.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<ApplicationDbContext>(item => item.UseSqlServer(config.GetConnectionString("conn")));


builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddSingleton<IEmailSender, EmailSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/FrontEnd/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); ;

app.UseAuthorization();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=FrontEnd}/{action=index}/{id?}");
app.MapControllerRoute(
    name: "admin",
    pattern: "{controller=Admin}/{action=Identity/Account/Register}/{id?}");


app.Run();
