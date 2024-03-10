using NUnit.Framework;
namespace SauceDemo_PageObject_Steps.Helpers;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class SeverityAttribute : PropertyAttribute
{
    public SeverityAttribute(SeverityLevel level) : base(level.ToString()) { }
}
