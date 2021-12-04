using System;

namespace SabadinEstoqueApi.Controllers
{
    [AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, AllowMultiple = false, Inherited = true)]
    public class InjectAttribute : Attribute
    {
    }
}