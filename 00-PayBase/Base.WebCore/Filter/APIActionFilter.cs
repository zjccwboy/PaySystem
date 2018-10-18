using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base.WebCore.Filter
{
    public class APIActionFilter : IActionFilter
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
