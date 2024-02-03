using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductReviewProject.Server.Data;
using ProductReviewProject.Server.IRepository;
using ProductReviewProject.Shared.Domain;
using SQLitePCL;

namespace ProductReviewProject.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetAccounts()
        {
            var userList = await _context.ApplicationUsers.ToListAsync();
            return Ok(userList);

        }
    }

    
}
