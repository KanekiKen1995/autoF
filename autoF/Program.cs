using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace autoF
{
    class Program
    {
        static IWebDriver driver;
        static void Main(string[] args)
        {
            Console.WriteLine("auto F");
            Post();
        }


        static void Post()
        {
            NewWindown("https://www.facebook.com/");

        }
        static void NewWindown(string url)
        {
           var pathChormeDỉver = Path.GetDirectoryName(Path.GetFullPath(@"chromedriver.exe"));
            driver = new ChromeDriver(pathChormeDỉver);
            driver.Url = url;
            //driver.Close();
        }

    }
}
