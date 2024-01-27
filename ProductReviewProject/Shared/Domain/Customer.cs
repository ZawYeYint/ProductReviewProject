using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Customer:BaseDomainModel
	{
		[Required]
		
		[StringLength(100, MinimumLength = 5, ErrorMessage = " Name does not meet length requirements")]
		public string? Name { get; set; }
		
		[Required]
		[DataType(DataType.PhoneNumber,ErrorMessage ="Invalid Contact Number")]
		public string? Contact {  get; set; }

		[Required]
		[DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Address")]
		[EmailAddress]
		public string? CustomerEmail { get; set; }

	}
}
	