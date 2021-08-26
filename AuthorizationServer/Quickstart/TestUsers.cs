// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users =>
        new List<TestUser>
        {
                new TestUser
                {
                    Username="Mostafa",
                    Password="12345",
                    SubjectId="112233",
                    Claims =
                    {
                        new System.Security.Claims.Claim(JwtClaimTypes.Name,"Mostafa Hosseinkhani"),
                        new System.Security.Claims.Claim(JwtClaimTypes.GivenName,"Mosi"),
                        new System.Security.Claims.Claim(JwtClaimTypes.FamilyName,"HosseinKhani"),
                        new System.Security.Claims.Claim(JwtClaimTypes.Email,"info@mhosseinkhani.ir"),
                        new System.Security.Claims.Claim(JwtClaimTypes.EmailVerified,"true",ClaimValueTypes.Boolean),
                        new System.Security.Claims.Claim(JwtClaimTypes.WebSite,"http://mhosseinkhani.ir"),
                        new System.Security.Claims.Claim(JwtClaimTypes.Address,JsonSerializer.Serialize(new{
                            country="iran",
                            city="Qom",
                            street="Karimi"
                        }))
                    }
                }
        };
    }
}