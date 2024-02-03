using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;




namespace ProductReviewProject.Client.Static
{
	public static class Endpoints
	{
		public static readonly string Prefix = "api";

		public static readonly string ProductsEndpoint = $"{Prefix}/products";
		public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
		public static readonly string RatingsEndpoint = $"{Prefix}/ratings";
		public static readonly string CustomersEndpoint = $"{Prefix}/customers";
		public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
		public static readonly string ApplicationUsersEndpoint = $"{Prefix}/applicationUsers";




	}
}
	