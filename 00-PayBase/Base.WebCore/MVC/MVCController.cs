using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base.WebCore.MVC
{
    public class MVCController : Controller
    {
        public static JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            DateFormatString = "yyyy-MM-dd HH:mm:ss",
            NullValueHandling = NullValueHandling.Ignore,
        };

        public override JsonResult Json(object data)
        {
            return base.Json(data, JsonSettings);
        }

        public string GetUserIp()
        {
            return this.HttpContext.GetUserIp();
        }
    }

    public static class HttpContextExtension
    {
        public static string GetUserIp(this HttpContext context)
        {
            var ip = context.Request.Headers["X-Forwarded-For"].FirstOrDefault();
            if (string.IsNullOrEmpty(ip))
            {
                ip = context.Connection.RemoteIpAddress.ToString();
            }
            return ip;
        }
    }
}
