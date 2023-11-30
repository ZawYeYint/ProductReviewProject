using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Review:BaseDomainModel
	{
		public string? Description { get; set; }
		public virtual Product? Product { get; set; }

		public virtual Customer? Customer { get; set; }
	}
}
