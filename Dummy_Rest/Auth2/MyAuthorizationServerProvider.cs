using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace Dummy_Rest.Auth2
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // 
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            if (context.UserName == "MREYES" && context.Password == "323120")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                identity.AddClaim(new Claim("username", "MREYES"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Maria Dolores Estrada"));
                context.Validated(identity);
            }
            else if (context.UserName == "web_o_android" && context.Password == "web_o_android")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "web_o_android"));
                identity.AddClaim(new Claim("username", "web_o_android"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "web_o_android"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
        }
    }
}