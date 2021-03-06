﻿using System.Collections.Generic;
using System.Security.Claims;

namespace Havit.Distiller.Facades.Infrastructure.Security.Claims
{
    public interface IClaimsCacheStore
    {
        List<Claim> GetClaims(UserContextInfo userContextInfo);

        void StoreClaims(UserContextInfo userContextInfo, List<Claim> claims);
    }
}