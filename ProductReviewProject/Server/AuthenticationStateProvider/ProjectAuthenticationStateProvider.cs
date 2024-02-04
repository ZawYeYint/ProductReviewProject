using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;



	public class ProjectAuthenticationStateProvider : AuthenticationStateProvider
	{
		public override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			var identity = new ClaimsIdentity(new[]
			{
			new Claim(ClaimTypes.Role, "Administrator"),
			new Claim(ClaimTypes.Role, "User"),
		}, "TestAuthType");

			var user = new ClaimsPrincipal(identity);

			return Task.FromResult(new AuthenticationState(user));
		}
	}
