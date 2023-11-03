using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ReservaDiscotecas_P.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;
using ReservaDiscotecas_P.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ReservaDiscotecas_PContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ReservaDiscotecas_PContext") ?? throw new InvalidOperationException("Connection string 'ReservaDiscotecas_PContext' not found.")));
var connectionString = builder.Configuration.GetConnectionString("DBContextSampleConnection") ?? throw new InvalidOperationException("Connection string 'DBContextSampleConnection' not found.");

builder.Services.AddDbContext<DBContextSample>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SampleUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<DBContextSample>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
