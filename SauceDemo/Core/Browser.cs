﻿using OpenQA.Selenium;

namespace SauceDemo.Core;

public class Browser
{
    public IWebDriver Driver { get; }

    public Browser()
    {
        Driver = new DriverFactory().GetChromeDriver()
            ?? throw new InvalidOperationException("Browser is not supported.");

        Driver.Manage().Window.Maximize();
        Driver.Manage().Cookies.DeleteAllCookies();
    }
}