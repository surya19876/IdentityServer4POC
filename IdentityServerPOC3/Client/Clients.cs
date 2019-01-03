using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerPOC3.Clients
{
    public static class Clients
    {
        public static List<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client
                {
                    ClientId = "api-user",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("test".Sha256())
                    },
                    AllowedGrantTypes = new List<string>()
                    {
                        GrantType.ResourceOwnerPassword
                    },
                    AllowedScopes = new List<string>()
                    {
                        "AuthenticationAPI",
                        "CustomerAPI"
                    }
                }
            };
        }

        public static List<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("AuthenticationAPI", "Authentication Service"),
                new ApiResource("CustomerAPI", "Customer Service")
            };
        }

    }
}
