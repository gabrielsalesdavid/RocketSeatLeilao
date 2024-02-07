using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.Filters;
using RocketSeatAuction.API.Repositories;

namespace RocketSeatAuction.API.Filters;

public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        try {
            var token = TokenOnRequest(context.HttpContext);

            var repository = new RocketSeatAuctionDbContext();
            var email = FromBase64String(token);
            var exist = repository.Users.Any(user => user.Email.Equals(email));

            if (exist == false)
            {
                context.Result = new UnauthorizedObjectResult("E-mail not valid");
            }
        }
        catch (Exception ex) {
            context.Result = new UnauthozizedObjectResult("E-mail not valid");
        }
    }

    private string TokenOnRequest(HttpContext context)
    {
        var authentication = context.Request.Headers.Authorization.ToString();

        if (string.IsNullOrEmpty(authentication))
        {
            throw new Exception("Token is missing.");
        }
        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);
        System.Text.Encoding.UTF8.GetString(data);
    }
}
