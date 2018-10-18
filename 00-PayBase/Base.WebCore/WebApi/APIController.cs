using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace Base.WebCore.WebApi
{
    public class APIController : ControllerBase
    {
        public class ActionFilter : IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext context)
            {
                Console.WriteLine("action执行之后");
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                Console.WriteLine("action执行之前");
            }
        }
    }
}
