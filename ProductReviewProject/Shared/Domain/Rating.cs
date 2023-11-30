using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Rating:BaseDomainModel
	{
		public string? Description {  get; set; }

		public int Value { get; set; }
		
		public virtual Review? Review { get; set; }

		public virtual Customer? Customer { get; set; }

	}
}
