using Newtonsoft.Json;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumBasic.Core;
using System.Security.Permissions;

namespace SeleniumBasic.Tests;

public class FirstTest : BaseTest
{
    [Test, Order(1)]
    [Description("Exercise 1")]
    public void ValidateSKF()
    {
        Driver.Navigate().GoToUrl("https://bymed.top/calc/%D1%81%D0%BA%D1%84-2148");
        Driver.SwitchTo().Frame(Driver.FindElement(By.XPath("//iframe[@src]")));

        IWebElement ageInput = Driver.FindElement(By.Id("age"));
        IWebElement сreatinineInput = Driver.FindElement(By.Id("cr"));
        IWebElement bodymassInput = Driver.FindElement(By.Id("mass"));
        IWebElement heightInput = Driver.FindElement(By.Id("grow"));
        IWebElement selectDropdown = Driver.FindElement(By.Id("cr-size"));
        IWebElement sexDropdown = Driver.FindElement(By.Id("sex"));
        IWebElement raceDropdown = Driver.FindElement(By.Id("race"));
        IWebElement calcButton = Driver.FindElement(By.XPath("//button[.='Рассчитать']"));
        SelectElement selectElement = new SelectElement(selectDropdown);
        SelectElement selectElement1 = new SelectElement(sexDropdown);
        SelectElement selectElement2 = new SelectElement(raceDropdown);

        ageInput.SendKeys("32");
        сreatinineInput.SendKeys("123");
        bodymassInput.SendKeys("80");
        heightInput.SendKeys("183");
        selectElement.SelectByIndex(0);
        selectElement1.SelectByIndex(0);
        selectElement2.SelectByIndex(0);

        calcButton.Click();

        Thread.Sleep(3000);
        IWebElement resultTextMDRD = Driver.FindElement(By.Id("mdrd_res"));
        Assert.That(resultTextMDRD.Text, Is.EqualTo("59.15"));

        IWebElement resultTextCKD = Driver.FindElement(By.Id("ckd_epi_res"));
        Assert.That(resultTextCKD.Text, Is.EqualTo("66.5"));

        IWebElement resultTextFormula = Driver.FindElement(By.Id("cge_res"));
        Assert.That(resultTextFormula.Text, Is.EqualTo("86.25"));
    }

    [Test, Order(2)]
    [Description("Exercise 2")]
    public void Laminate()
    {
        Driver.Navigate().GoToUrl("https://home-ex.ru/calculation/");
        Thread.Sleep(5000);
        var js = (IJavaScriptExecutor)Driver;

        IWebElement roomLengthInput = Driver.FindElement(By.Id("ln_room_id"));
        IWebElement roomWidthInput = Driver.FindElement(By.Id("wd_room_id"));
        IWebElement dieLengthInput = Driver.FindElement(By.Id("ln_lam_id"));
        IWebElement dieWidthInput = Driver.FindElement(By.Id("wd_lam_id"));
        IWebElement numberOfDiesPerPackage = Driver.FindElement(By.Id("n_packing"));
        IWebElement packingArea = Driver.FindElement(By.Id("area"));

        IWebElement selectDropdownLayingMethodLaminate = Driver.FindElement(By.Id("laying_method_laminate"));
        SelectElement selectLayingMethodLaminate = new SelectElement(selectDropdownLayingMethodLaminate);

        IWebElement laminateLayingDirection = Driver.FindElement(By.XPath("//input[@id='direction-laminate-id1']"));
        laminateLayingDirection.Click();

        IWebElement calcButton = Driver.FindElement(By.Id("btn_calculate"));

        roomLengthInput.Clear();
        roomWidthInput.Clear();
        dieLengthInput.Clear();
        dieWidthInput.Clear();
        numberOfDiesPerPackage.Clear();

        roomLengthInput.SendKeys("500");
        roomWidthInput.SendKeys("300");
        dieLengthInput.SendKeys("2440");
        dieWidthInput.SendKeys("320");
        numberOfDiesPerPackage.SendKeys("20");
        packingArea.SendKeys("400");
        js.ExecuteScript("document.getElementById('min_length_segment_id').value='500'");
        js.ExecuteScript("document.getElementById('indent_walls_id').value='13'");
        selectLayingMethodLaminate.SelectByIndex(2);

        calcButton.Click();

        Thread.Sleep(5000);
        Assert.Multiple(() => {
            IWebElement resultCalculate = Driver.FindElement(By.CssSelector("div.calc-result"));
            Assert.That(resultCalculate.Text.Replace("\r\n", ""),
            Is.EqualTo("Требуемое количество плашек ламината: 20Количество упаковок ламината: 1Стоимость ламината: 0 рубВес ламината: 0 кг"));
        });
    }






}

