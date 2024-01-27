using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Product:BaseDomainModel
	{
		[Required]
		

		[StringLength(100,ErrorMessage ="Name too long")]
		public string? Name { get; set; }

		[Required]

		[StringLength(100,ErrorMessage ="Description too long")]
		public string? Description { get; set; }

		[Required]
		[DataType(DataType.Currency,ErrorMessage="Invalid Amount")]
		public int? Price { get; set; }
	}
}
