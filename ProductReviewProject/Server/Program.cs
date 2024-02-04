using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using ProductReviewProject.Server.Data;
using ProductReviewProject.Server.Models;
using Microsoft.AspNetCore.Identity;
using ProductReviewProject.Server.IRepository;
using ProductReviewProject.Server.Repository;
using Microsoft.AspNetCore.Authorization;
using ProductReviewProject.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;


namespace RegisterUser
{
	public class Program
	{
		public static async Task Main(string[] args)

		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
			builder.Services.AddDbContext<ApplicationDbContext>(options =>
				options.UseSqlServer(connectionString)
				.EnableSensitiveDataLogging());
			builder.Services.AddDatabaseDeveloperPageExceptionFilter();

			builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
			.AddRoles<IdentityRole>()
			.AddEntityFrameworkStores<ApplicationDbContext>();

			//builder.Services.AddAuthorizationCore(options =>
			//{
			//	options.AddPolicy("Administrator", policy =>
			//		policy.RequireClaim("role", "Administrator"));
			//});
			//builder.Services.AddScoped<AuthenticationStateProvider, ProjectAuthenticationStateProvider>();




			builder.Services.AddIdentityServer()
				.AddApiAuthorization<ApplicationUser, ApplicationDbContext>();

			builder.Services.AddAuthentication()
				.AddIdentityServerJwt();






			builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();



			builder.Services.AddControllersWithViews().AddNewtonsoftJson(op => op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
			builder.Services.AddRazorPages();






			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseMigrationsEndPoint();
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseIdentityServer();
			app.UseAuthorization();


			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");

			using (var scope = app.Services.CreateScope())
			{
				var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
				var roles = new[] { "admin", "manager", "member" };

				foreach (var role in roles)
				{
					if (!await roleManager.RoleExistsAsync(role))
						await roleManager.CreateAsync(new IdentityRole(role));

				}
			}


			using (var scope = app.Services.CreateScope())
			{
				var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

				string email = "admin@admin.com";
				string password = "Test1234!";
				if(await userManager.FindByEmailAsync(email)==null)
				{
					var user = new ApplicationUser();
					user.UserName = email;
					user.Email = email;
					await userManager.CreateAsync(user,password);
					await userManager.AddToRoleAsync(user, "Admin");
				}
			}


			app.Run();
		}
	}
}



