using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ProductReviewProject.Shared.Domain;


namespace ProductReviewProject.Server.Configurations.Entities
{
	public class RatingSeedConfiguration : IEntityTypeConfiguration<Rating>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Rating> builder)
		{
			builder.HasData
			(
			new Rating
			{
				Id = 1,
				Value = 3,
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Rating
			{
				Id = 2,
				Value = 4,
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
