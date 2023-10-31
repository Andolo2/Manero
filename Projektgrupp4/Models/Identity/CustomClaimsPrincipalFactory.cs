using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Projektgrupp4.Models.Entities;
using System.Security.Claims;

namespace Projektgrupp4.Models.Identity;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<UserEntity>
{
    public CustomClaimsPrincipalFactory(UserManager<UserEntity> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(UserEntity user)
    {
        var claimsIdentity = await base.GenerateClaimsAsync(user);
        claimsIdentity.AddClaim(new Claim("DisplayName", $"{user.Name}"));

        var roles = await UserManager.GetRolesAsync(user);
        claimsIdentity.AddClaims(roles.Select(x => new Claim(ClaimTypes.Role, x)));

        return claimsIdentity;
    }
}
