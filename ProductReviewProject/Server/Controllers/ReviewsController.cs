﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductReviewProject.Server.Data;
using ProductReviewProject.Server.IRepository;
using ProductReviewProject.Shared.Domain;

namespace ProductReviewProject.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReviewsController : ControllerBase
	{
		//private readonly ApplicationDbContext _context;
		private readonly IUnitOfWork _unitOfWork;

		public ReviewsController(IUnitOfWork unitOfWork)
		{
			//_context = context;
			_unitOfWork = unitOfWork;
		}

		// GET: api/Reviews
		[HttpGet]
		public async Task<ActionResult> GetReviews()
		{
			var reviews = await _unitOfWork.Reviews.GetAll();
			return Ok(reviews);


		}

		// GET: api/Reviews/5
		[HttpGet("{id}")]
		public async Task<ActionResult<Review>> GetReview(int id)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.Id == id);

			if (review == null)
			{
				return NotFound();
			}
			return Ok(review);
		}

		// PUT: api/Reviews/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutReview(int id, Review review)
		{
			if (id != review.Id)
			{
				return BadRequest();
			}

			// _context.Entry(review).State = EntityState.Modified;
			_unitOfWork.Reviews.Update(review);

			try
			{
				//await _context.SaveChangesAsync();
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await ReviewExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Reviews
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Review>> PostReview(Review review)
		{

			await _unitOfWork.Reviews.Insert(review);
			await _unitOfWork.Save(HttpContext);

			return CreatedAtAction("GetReview", new { id = review.Id }, review);
		}

		// DELETE: api/Reviews/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteReview(int id)
		{

			var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
			if (review == null)
			{
				return NotFound();
			}

			await _unitOfWork.Reviews.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> ReviewExists(int id)
		{
			var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
			return review != null;
		}
	}
}
