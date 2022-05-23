using System;
using System.Reflection;
using Panda.DynamicWebApi;

namespace ReaderSharp.Web.API.Services.DynamicAPI
{
    public class ServiceLocalSelectController : ISelectController
    {
        public bool IsController(Type type)
        {
            return type.IsPublic && type.GetCustomAttribute<APIServiceAttribute>() != null;
        }
    }
}