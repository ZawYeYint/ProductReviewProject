using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Product:BaseDomainModel
	{
		public string? Name { get; set; }
		public string? Description { get; set; }
	}
}
