using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace RouteYapilanmasi3.Constraints
{
    public class CustomConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return true;
        }
    }
}
