using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;

namespace Base.WebCore.WebApi
{
    public class APIController : ControllerBase
    {
        public static JsonSerializerSettings JsonSettings = new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat,
            DateFormatString = "yyyy-MM-dd HH:mm:ss",
            NullValueHandling = NullValueHandling.Ignore,
        };
    }
}
