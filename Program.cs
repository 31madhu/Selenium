using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            try
            {
                IWebDriver drive = new ChromeDriver();                
                drive.Navigate().GoToUrl("https://localhost:7036/Home/LoginCustomer");
                IWebElement CustomerIdInput = drive.FindElement(By.Name("CustomerId"));
                CustomerIdInput.SendKeys("9");

                IWebElement CustomerNameinput = drive.FindElement(By.Name("CustomerName"));
                CustomerNameinput.SendKeys("Madhu Patel");

                IWebElement Login = drive.FindElement(By.ClassName("btn btn-success"));
                Login.Click();
                //Login.Submit();

                //drive.Navigate().GoToUrl("https://localhost:7036/Home/LoginSuccess");

                Thread.Sleep(5000);
                drive.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("something went wrong" + ex.Message);
            }



        


        }
    }
}
