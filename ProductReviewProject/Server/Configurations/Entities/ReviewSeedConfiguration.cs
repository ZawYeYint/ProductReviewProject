using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ProductReviewProject.Shared.Domain;


namespace ProductReviewProject.Server.Configurations.Entities
{
	public class ReviewSeedConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Review> builder)
		{
			builder.HasData
			(
			new Review
			{
				Id = 1,
				Description = "Good Review",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Review
			{
				Id = 2,
				Description = "Amazing 10/10",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
