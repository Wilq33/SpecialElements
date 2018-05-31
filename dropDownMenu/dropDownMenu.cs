

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class DropDownMenu
{

    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    static IWebElement elementFromDropDownMenu;

    static void Main()
    {

        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";


        driver.Navigate().GoToUrl(url);

        //Checking first and third element
        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

        Console.WriteLine("The third option in drop down menu is: " + elementFromDropDownMenu.GetAttribute("value"));

        elementFromDropDownMenu.Click();

        Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

        Thread.Sleep(3000);


        //Checking all available options from menu
        for (int i = 1; i <= 4; i++)
        {
            dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";

            elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));

            Console.WriteLine("The " + i + " option in drop down menu is: " + elementFromDropDownMenu.GetAttribute("value"));

        }

        Thread.Sleep(5000);

        driver.Quit();
    }
}

