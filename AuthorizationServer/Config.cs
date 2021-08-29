// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;
using Shared;
using System.Collections.Generic;

namespace AuthorizationServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email()
        };
        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("read-homework")
            };
        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId=ConstData.AuthorizationCodeFlowClientId,
                    ClientSecrets={new Secret(ConstData.AuthorizationCodeFlowClientSecret.Sha256()) },
                    AllowedGrantTypes=GrantTypes.Code,
                    RedirectUris={ "https://localhost:5010" },
                    PostLogoutRedirectUris={ "https://localhost:5010/logout-callback" },
                    AllowedScopes=new List<string>
                    {
                      //  IdentityServerConstants.StandardScopes.OpenId,
                        //IdentityServerConstants.StandardScopes.Profile,
                        //IdentityServerConstants.StandardScopes.Email,
                        "read-homework"
                    },
                    RequireConsent=true,
                    RequirePkce = false,

                },
                new Client
                {
                    ClientId=ConstData.AuthorizationClientCredentialsFlowId,
                    ClientSecrets={ new Secret(ConstData.ClientCredentialsFlowSecret.Sha256()) },
                    RequireClientSecret=true,
                    AllowedGrantTypes=GrantTypes.ClientCredentials,
                    RequirePkce=false,
                    RequireConsent=false,
                     AllowedScopes=new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "read-homework"
                    },
                 }
            };
    }
}