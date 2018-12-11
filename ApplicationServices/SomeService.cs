using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationServices
{
    public class SomeService : ISomeService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public SomeService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public IEnumerable<string> SomeMethod()
        {
            var headersValues = httpContextAccessor.HttpContext.Request.Headers.Values.Select(e => e.ToString());

            return headersValues;
        }
    }
}
