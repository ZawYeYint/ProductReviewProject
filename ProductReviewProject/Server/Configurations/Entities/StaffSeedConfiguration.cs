using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using ProductReviewProject.Shared.Domain;

namespace ProductReviewProject.Server.Configurations.Entities
{
	public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Staff> builder)
		{
			builder.HasData
			(
			new Staff
			{
				Id = 1,
				Name = "Staff1",
				Contact = "123456789",
				StaffEmail="Staff1.com",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			},
			new Staff
			{
				Id = 2,
				Name = "Staff2",
				Contact = "123456789",
				StaffEmail = "Staff1.com",
				DateCreated = DateTime.Now,
				DateUpdated = DateTime.Now,
				CreatedBy = "System",
				UpdatedBy = "System"
			}
			);
		}
	}
}
