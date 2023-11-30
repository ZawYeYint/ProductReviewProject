using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProductReviewProject.Server.Configurations.Entities;
using ProductReviewProject.Server.Models;
using ProductReviewProject.Shared.Domain;

namespace ProductReviewProject.Server.Data
{
	public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public ApplicationDbContext(
			DbContextOptions options,
			IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
		{
		}

		public DbSet<Review> Reviews { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Rating> Ratings { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Staff> Staffs { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new ProductSeedConfiguration());

			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new RatingSeedConfiguration());

			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new ReviewSeedConfiguration());

			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new RoleSeedConfiguration());

			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new UserRoleSeedConfiguration());

			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new UserSeedConfiguration());
		}
	}
}
