using ProductReviewProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ProductReviewProject.Server.IRepository
{
	public interface IUnitOfWork : IDisposable
	{
		Task Save(HttpContext httpContext);
		IGenericRepository<Product> Products { get; }
		IGenericRepository<Review> Reviews { get; }
		IGenericRepository<Rating> Ratings { get; }
		IGenericRepository<Customer> Customers { get; }
		IGenericRepository<Staff> Staffs { get; }
		
	}
}