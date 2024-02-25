using NUnit.Framework;
namespace SauceDemo.Helpers;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class SeverityAttribute : PropertyAttribute
    {
        public SeverityAttribute(SeverityLevel level) : base(level.ToString()) { }
    }
