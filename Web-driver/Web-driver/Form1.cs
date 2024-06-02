using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Support.UI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Web_driver
{
    public partial class Form1 : Form
    {
        private String url = "https://drawsql.app/";
        private String urlcn = "https://opensource-demo.orangehrmlive.com/";
        private String urlcn3 = "https://myshoes.vn/";
        private String urlcn4 = "https://www.youtube.com/";
        public Form1()
        {
            InitializeComponent();
            txtcn1.Text = url;
            txtcn2.Text = urlcn;
            txtcn3.Text = urlcn3;
            txtcn4.Text = urlcn4;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncn1_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url = url;
            driver.Navigate();
            System.Threading.Thread.Sleep(1000);
            IWebElement button_submit = driver.FindElement(By.XPath("//a[@class='hidden lg:block font-medium text-gray-500 hover:text-gray-900 ml-6' and @href='/login']"));
            button_submit.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement button_submit_register = driver.FindElement(By.CssSelector("a.ml-3.text-indigo-600.hover\\:text-indigo-500[href='https://drawsql.app/register']"));
            button_submit_register.Click();

            //input 
            System.Threading.Thread.Sleep(1000);
            IWebElement element_name = driver.FindElement(By.Id("name"));
            element_name.SendKeys("Bui Thi Phuong Mai");

            IWebElement element_email = driver.FindElement(By.Id("email"));
            element_email.SendKeys("geqisodavefa@rungel.net\r\n");

            IWebElement element_password = driver.FindElement(By.Id("password"));
            element_password.SendKeys("Mai2003@");

            System.Threading.Thread.Sleep(2000);
            IWebElement btnSignUp = driver.FindElement(By.CssSelector("button.inline-flex.items-center.px-4.py-2.bg-indigo-500.border.border-transparent.rounded-md.font-medium.text-sm.text-white.tracking-wide.hover\\:bg-indigo-600.focus\\:outline-none.focus\\:ring-2.focus\\:ring-offset-2.focus\\:ring-offset-gray-50.focus\\:ring-indigo-500.disabled\\:opacity-25.transition.mt-8.w-full.justify-center"));
            btnSignUp.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement element_textteam = driver.FindElement(By.Id("name"));
            element_textteam.SendKeys("Team tester");

            System.Threading.Thread.Sleep(2000);
            IWebElement btnCreateTeam = driver.FindElement(By.XPath("//*[@id=\"app\"]/main/div[2]/div/div/div[2]/form/button"));
            btnCreateTeam.Click();
        }

        private void btncn2_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url = urlcn3;
            driver.Navigate();
            System.Threading.Thread.Sleep(3000);

            
            IWebElement btnProduct = driver.FindElement(By.XPath("//*[@id=\"products-665afaa835b16-tab-1\"]/div/div[2]/div/div[2]"));
            btnProduct.Click();
            
            IWebElement btnProductAdd = driver.FindElement(By.Id("button-cart"));
            btnProductAdd.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement button_Cart = driver.FindElement(By.ClassName("btn-extra-46"));
            button_Cart.Click();

            System.Threading.Thread.Sleep(5000);
            IWebElement button_quantity = driver.FindElement(By.ClassName("fa-angle-up"));
            button_quantity.Click();
        }

        private void btncn3_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url = urlcn;
            driver.Navigate();
            System.Threading.Thread.Sleep(3000);


            IWebElement element_username = driver.FindElement(By.Name("username"));
            element_username.SendKeys("Admin");

            IWebElement element_password = driver.FindElement(By.Name("password"));
            element_password.SendKeys("admin123");

            System.Threading.Thread.Sleep(1000);
            IWebElement button_send_login = driver.FindElement(By.ClassName("orangehrm-login-button"));
            button_send_login.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement button_submit_edit = driver.FindElement(By.XPath("//a[@class='oxd-main-menu-item' and @href='/web/index.php/pim/viewPimModule']"));
            button_submit_edit.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement button_click_text = driver.FindElement(By.XPath("//button[contains(@class, 'oxd-button') and .//i[contains(@class, 'oxd-icon')]]"));
            button_click_text.Click();

            System.Threading.Thread.Sleep(1000);
            IWebElement element_firstName = driver.FindElement(By.Name("firstName"));
            element_firstName.SendKeys("Bui Thi Phuong Mai");

            IWebElement element_middleName = driver.FindElement(By.Name("middleName"));
            element_middleName.SendKeys("Thi Phuong");

            IWebElement element_lastName = driver.FindElement(By.Name("lastName"));
            element_lastName.SendKeys("Mai");

            System.Threading.Thread.Sleep(3000);

            IWebElement saveButton = driver.FindElement(By.CssSelector("button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space"));

            // Click the button
            saveButton.Click();
        }

        private void btncn4_Click(object sender, EventArgs e)
        {
            ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            chrome.HideCommandPromptWindow = true;
            IWebDriver driver = new ChromeDriver(chrome);
            driver.Url = urlcn4;
            driver.Navigate();
            System.Threading.Thread.Sleep(3000);

            IWebElement btntextSearch = driver.FindElement(By.Name("search_query"));
            btntextSearch.SendKeys("Tình đắng như ly cafe");

            System.Threading.Thread.Sleep(2000);
            IWebElement btnSearch = driver.FindElement(By.XPath("//*[@id=\"search-icon-legacy\"]/yt-icon/yt-icon-shape/icon-shape/div"));
            btnSearch.Click();

            System.Threading.Thread.Sleep(2000);
            /*IWebElement video = driver.FindElement(By.XPath("//*[@id=\"dismissible\"]/div/div[3]/yt-formatted-string"));
            video.Click();*/
            IWebElement video = driver.FindElement(By.Id("dismissible"));
            video.Click();
        }
    }
}
