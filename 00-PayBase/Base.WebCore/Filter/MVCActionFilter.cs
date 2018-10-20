using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc;

namespace Base.WebCore.Filter
{
    public class MVCActionFilter : IActionFilter
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
