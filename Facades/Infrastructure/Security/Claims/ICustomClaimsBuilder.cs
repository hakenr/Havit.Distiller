using System.Collections.Generic;
using System.Security.Claims;

namespace Havit.Distiller.Facades.Infrastructure.Security.Claims
{
    public interface ICustomClaimsBuilder
    {
        List<Claim> GetCustomClaims(ClaimsPrincipal principal);
    }
}