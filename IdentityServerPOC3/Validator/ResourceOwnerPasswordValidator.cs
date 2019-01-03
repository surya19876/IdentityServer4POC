using IdentityServer4.Validation;
using IdentityServerPOC3.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace IdentityServerPOC3.Validator
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public UserContext _authenticationContext;
        public ResourceOwnerPasswordValidator()
        {
            _authenticationContext = new UserContext();
        }
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            var user = _authenticationContext.User
                .SingleOrDefault(e =>
                    e.sLogin.Equals(context.UserName)
                    && !string.IsNullOrEmpty(context.Password));

            if(user == null)
            {
                context.Result = new GrantValidationResult(TokenErrors.InvalidRequest, "Invalid credentials");
                return Task.FromResult(0);
            }

            context.Result = new GrantValidationResult(user.pkUserTable.ToString(), "password");
            return Task.FromResult(0);
        }
    }
}
