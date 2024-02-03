using Microsoft.AspNetCore.Identity;

namespace ProductReviewProject.Server.Models
{
	public class ApplicationUser : IdentityUser
	{
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ApplicationUser()
		{ }

		//public ApplicationUser(ApplicationUser AppUser)
		//{
		//	this.Id = AppUser.Id;
		//	this.PhoneNumber = AppUser.PhoneNumber;
		//	this.NormalizedEmail = AppUser.NormalizedEmail;
		//	this.Email = AppUser.Email;
		//	this.NormalizedUserName = AppUser.NormalizedUserName;
		//	this.UserName = AppUser.UserName;
		//}

		

	}
}
