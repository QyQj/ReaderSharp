using System;

namespace ReaderSharp.Controllers.DynamicAPI
{
    [AttributeUsage(AttributeTargets.Class)]
    public class APIServiceAttribute : Attribute
    {
        public APIServiceAttribute()
        {
            ServiceName = string.Empty;
        }

        public APIServiceAttribute(string serviceName)
        {
            ServiceName = serviceName;
        }

        public string ServiceName { get; }
    }
}