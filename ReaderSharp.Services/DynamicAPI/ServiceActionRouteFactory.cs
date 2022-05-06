using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Panda.DynamicWebApi;
using System.Reflection;

namespace ReaderSharp.Controllers.DynamicAPI
{
    public class ServiceActionRouteFactory : IActionRouteFactory
    {
        public string CreateActionRouteModel(string areaName, string controllerName, ActionModel action)
        {
            var controllerType = action.ActionMethod.DeclaringType;
            var serviceAttribute = controllerType.GetCustomAttribute<APIServiceAttribute>();

            var _controllerName = serviceAttribute.ServiceName == string.Empty ? controllerName.Replace("Service", "") : serviceAttribute.ServiceName.Replace("Service", "");

            return $"api/{_controllerName}/{action.ActionName.Replace("Async", "")}";
        }
    }
}