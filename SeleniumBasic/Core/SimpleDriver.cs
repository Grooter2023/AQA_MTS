using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumBasic.Core;

public class SimpleDriver
{
    public IWebDriver Driver
    {
        get
        {


            /* //A)
             return new ChromeDriver(
             @"\Users\Tanya\source\repos\AQA_MTS\SeleniumBasic\Resources\");
            */

            /* //B)
              string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
              return new ChromeDriver(path + @"\Resources\");
            */

             //C)
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(basePath + @"\Resources\");
           
        }
    }
}