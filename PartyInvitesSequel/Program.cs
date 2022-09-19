using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Helpers;
using PartyInvitesSequel.Models.Interfaces;
using PartyInvitesSequel.Models.Repositories;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);
//Services to container
string ConnectionString = builder.Configuration.GetConnectionString("Default");

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IPersonList, GuestList>();
builder.Services.AddScoped<IRepository<Guest>, GuestRepository>();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(ConnectionString));

//Authenticatie
builder.Services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", config =>
{
    config.Cookie.Name = "CookieAuth";
    config.LoginPath = "/Home/Verplaatsen";
});

//Authorisatie
builder.Services.AddAuthorization(config =>
{
    var DefaultPolicyBuilder = new AuthorizationPolicyBuilder();
    var DefaultPolicy = DefaultPolicyBuilder
    .RequireAuthenticatedUser()
    .RequireClaim(ClaimTypes.Name)
    .Build();

    config.DefaultPolicy = DefaultPolicy;
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
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapDefaultControllerRoute();
//Mapping to other Controller and view
app.MapControllerRoute(
    name: "FormParty",
    pattern: "{controller}/Form_Party/{index?}",
    defaults: new { controller = "Profile", action = "Profile"});


app.Run();
