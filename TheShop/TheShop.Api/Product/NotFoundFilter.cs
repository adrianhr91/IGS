using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace TheShop.Api.Product
{
    public class NotFoundFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.Result = new ContentResult()
            {
                StatusCode = (int)HttpStatusCode.NotFound
            };
        }
    }
}
