using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LogATicket
{
    public class Utility
    {
        public static string CaptureScreen(IWebDriver driver,string fileName)
        {
            ITakesScreenshot screenshot=(ITakesScreenshot)driver;
            Screenshot ss=screenshot.GetScreenshot();

            string path=fileName+DateTime.Now.ToString("yyyy-mm-dd-HH-mm-ss");
            string filepath=@"C:\Users\DebanjanD\Desktop\LogATicket\Screenshot\"+path+".png";
            ss.SaveAsFile(filepath);
            return filepath;

        }
    }
}