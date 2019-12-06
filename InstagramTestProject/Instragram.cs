using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InstagramTestProject
{
    public partial class Instragram : Form
    {
        public Instragram()
        {
            InitializeComponent();
        }

        IWebDriver driver;
        private void Instragram_Load(object sender, EventArgs e)
        {

        }

        public async void DriverStart(string proxy)
        {
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            if (!string.IsNullOrEmpty(proxy))
            {
                chromeOptions.AddArgument("--proxy-server=" + proxy);
            }
            chromeOptions.EnableMobileEmulation("iPhone X");
            chromeOptions.AddArgument("disable-infobars");
            chromeOptions.AddArgument("--allow-file-access");
            chromeOptions.AddArgument("--disable-web-security");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            driver = new ChromeDriver(chromeDriverService, chromeOptions, TimeSpan.FromMinutes(3.0));
            await Task.Delay(2000);
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                DriverStart(null);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(59);
                driver.Navigate().GoToUrl("https://www.instagram.com/accounts/login/");
                IWebElement kullaniciAdiEl = driver.FindElement(By.Name("username"));
                kullaniciAdiEl.SendKeys(txtKullaniciAdi.Text);
                Thread.Sleep(1000);
                IWebElement sifreEl = driver.FindElement(By.Name("password"));
                sifreEl.SendKeys(txtSifre.Text);
                Thread.Sleep(1000);
                IWebElement girisYap = driver.FindElement(By.CssSelector("#react-root > section > main > article > div > div > div > form > div:nth-child(7) > button"));
                girisYap.Click();
                IWebElement simdiDegil = driver.FindElement(By.CssSelector("#react-root > section > main > div > button"));
                simdiDegil.Click();
                IWebElement iptal = driver.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.mt3GC > button.aOOlW.HoLwm"));
                iptal.Click();
                IWebElement iptal2 = driver.FindElement(By.CssSelector("body > div.RnEpo.Yx5HN > div > div > div.mt3GC > button.aOOlW.HoLwm"));
                iptal2.Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        string gonderi = "";

        private void BtnResimSec_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Resim Dosyaları |*.jpg;*.jpeg;*.png";
                file.Title = "Resim Seçin";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    gonderi = file.FileName;
                    lblGonderiIsim.Text = file.SafeFileName;
                }
                else
                {
                    MessageBox.Show("Resim Seçilmedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPaylas_Click(object sender, EventArgs e)
        {
            try
            {
                driver.FindElement(By.CssSelector("#react-root > section > nav.NXc7H.f11OC > div > div > div.KGiwt > div > div > div.q02Nz._0TPg > span")).Click();
                IWebElement iptal3 = driver.FindElement(By.CssSelector("body > div.RnEpo.xpORG._9Mt7n > div > div.YkJYY > div > div:nth-child(5) > button"));
                iptal3.Click();
                Thread.Sleep(1500);
                SendKeys.Send(gonderi);
                Thread.Sleep(1500);
                SendKeys.Send("(ENTER)");
                //driver.FindElement(By.Id("Value")).SendKeys(OpenQA.Selenium.Keys.Return);
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector("#react-root > section > div.Scmby > header > div > div.mXkkY.KDuQp > button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector("#react-root > section > div.A9bvI > section.IpSxo > div.NfvXc > textarea")).SendKeys("Bu bir test paylaşımıdır.");
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector("#react-root > section > div.Scmby > header > div > div.mXkkY.KDuQp > button")).Click();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
