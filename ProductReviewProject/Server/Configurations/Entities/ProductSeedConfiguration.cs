using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ProductReviewProject.Shared.Domain;

namespace ProductReviewProject.Server.Configurations.Entities
{
	public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
		{
			builder.HasData
			(
			new Product
			{
				Id = 1,
				Name = "Product1",
				Description="Product1",
				Price=1,
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Product
			{
				Id = 2,
				Name = "Product2",
				Description = "Product2",
				Price = 2,
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
