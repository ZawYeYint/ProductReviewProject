﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewProject.Shared.Domain
{
	public class Staff:BaseDomainModel
	{
		public string? Name { get; set; }
		public string? Contact { get; set; }
	}
}
