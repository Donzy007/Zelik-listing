using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;

namespace Zelik
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var settting = config.Formatters.JsonFormatter.SerializerSettings;
            settting.ContractResolver = new CamelCasePropertyNamesContractResolver();
            settting.Formatting = Formatting.Indented;

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
