using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ProductReviewProject.Shared.Domain;

namespace ProductReviewProject.Server.Configurations.Entities
{
	public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Customer> builder)
		{
			builder.HasData
			(
			new Customer
			{
				Id = 1,
				Name = "Customer1",
				Contact="123456789",
				CustomerEmail = "Product.com",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Customer
			{
				Id = 2,
				Name = "Customer2",
				Contact = "123456789",
				CustomerEmail = "Product.com",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
