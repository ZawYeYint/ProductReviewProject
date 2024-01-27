using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Rating:BaseDomainModel
	{
		[Required]
		[StringLength(100, ErrorMessage = "Description too long")]
		public string? Description {  get; set; }

		[Required]
		[Range(0, 5, ErrorMessage = "Value must be between 0 and 5.")]

		public int Value { get; set; }

		[Required]
		public int? CustomerId { get; set; }


		public virtual Customer? Customer { get; set; }
		[Required]
		public int? ProductId { get; set; }

		public virtual Product? Product { get; set; }

	}
}
