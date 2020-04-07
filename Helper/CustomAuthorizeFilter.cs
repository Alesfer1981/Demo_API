using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_API.Helper
{
    public class CustomAuthorizeFilter : IAsyncAuthorizationFilter
    {
        public AuthorizationPolicy Policy { get; }

        public CustomAuthorizeFilter(AuthorizationPolicy policy)
        {
            Policy = policy ??
                throw new ArgumentNullException(nameof(policy));
        }

        public Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            throw new NotImplementedException();
        }
    }

}
