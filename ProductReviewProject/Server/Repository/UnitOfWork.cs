﻿
using ProductReviewProject.Server.Data;
using ProductReviewProject.Server.IRepository;
using ProductReviewProject.Server.Models;
using ProductReviewProject.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProductReviewProject.Server.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _context;
		private IGenericRepository<Product> _products;
		private IGenericRepository<Customer> _customers;
		private IGenericRepository<Staff> _staffs;
		private IGenericRepository<Rating> _ratings;
		private IGenericRepository<Review> _reviews;
		
	

		public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
		{
			_context = context;
		}
		public IGenericRepository<Product> Products
			=> _products ??= new GenericRepository<Product>(_context);
		public IGenericRepository<Customer> Customers
			=> _customers ??= new GenericRepository<Customer>(_context);
		public IGenericRepository<Staff> Staffs
			=> _staffs ??= new GenericRepository<Staff>(_context);
		public IGenericRepository<Rating> Ratings
			=> _ratings ??= new GenericRepository<Rating>(_context);
		public IGenericRepository<Review> Reviews
			=> _reviews ??= new GenericRepository<Review>(_context);
		



		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}

		public async Task Save(HttpContext httpContext)
		{
			//To be implemented
			string user = "System";

			var entries = _context.ChangeTracker.Entries()
				.Where(q => q.State == EntityState.Modified ||
					q.State == EntityState.Added);

			foreach (var entry in entries)
			{
				((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
				((BaseDomainModel)entry.Entity).UpdatedBy = user;
				if (entry.State == EntityState.Added)
				{
					((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
					((BaseDomainModel)entry.Entity).CreatedBy = user;
				}
			}

			await _context.SaveChangesAsync();
		}
	}
}