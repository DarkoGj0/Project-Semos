using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Threading;

namespace Semos_Vezba
{

    public class CentralenRegistar
    {

        [Test]
        public void ОсновајСубјект()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Дома")).Click();
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Основај нов субјект")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Проверка и резервација на име на субјект")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,700)");
            Thread.Sleep(2000);
            driver.Url = "https://e-submit.crm.com.mk/sso/login.aspx?ReturnUrl=https%3a%2f%2fwww.crm.com.mk%3a443%2fNameReservation%2fusers%2fMakeReservation.aspx";
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcLogin1_TxtUserName")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcLogin1_TxtUserName")).Clear();
            driver.FindElement(By.Id("cphMain_UcLogin1_TxtUserName")).SendKeys("Darko");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcLogin1_TxtPassword")).Clear();
            driver.FindElement(By.Id("cphMain_UcLogin1_TxtPassword")).SendKeys("123456");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcLogin1_BtnLogin")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void НајчестоКористениПолиња()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);  
            driver.FindElement(By.XPath("//div[@id='mainheader']/div/label[3]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='mainheader']/div/label[4]")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public void НајчестоПоставуваниПрашања()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1400)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q01']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q01']/h3")).Text, "^Колку време е потребно за добивање на потврда[\\s\\S] \\(хартиена потврда\\)$"));
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q11']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q11']/h3")).Text, "^Кој сѐ може да биде подносител на барање за добивање податоци од регистрите на ЦРРСМ[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,1800)");
            driver.FindElement(By.XPath("//div[@id='q21']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q21']/h3")).Text, "^Како да креирам кориснички налог на системите на ЦРРСМ[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2000)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q31']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q31']/h3")).Text, "^Како да побарам пристап до системот, по успешно креираниот кориснички налог[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2300)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q41']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q41']/h3")).Text, "^Како да станам регистриран корисник во Дистрибутивен систем[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,2800)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q51']/h3")).Click();
            Thread.Sleep(2000); 
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q51']/h3")).Text, "^Кои информации можам да ги добијам преку Дистрибутивниот Систем[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,4000)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q61']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q61']/h3")).Text, "^На кои начини може да поднесам пријава за основање, промена или бришење на правно лице во Трговскиот регистар и Регистарот на други правни лица[\\s\\S] Дали можам самостојно да поднесам пријава или морам да ги користам услугите на Регистрационен агент[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,5500)");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("q71")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q71']/h3")).Text, "^Кои постапки на ликвидација, односно бришење се возможни за различните типови на правни лица[\\s\\S]$"));
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,7500)");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q81']/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.IsTrue(Regex.IsMatch(driver.FindElement(By.XPath("//div[@id='q81']/h3")).Text, "^Дали бонитет се однесува на информацијата за финансиско-економска состојба[\\s\\S]$"));
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q81']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q71']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q61']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q51']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q41']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q31']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q21']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q11']/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='q01']/h3")).Click();
            driver.Close();
        }
       
        [Test]
        public void Пребарување()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("companySearch")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("companySearch")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("companySearch")).SendKeys("DOOEL");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='mainheader']/div/div[4]/crm-cnt-basicprofile-home/div[2]/div[2]/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-basicprofile/crm-cnt-basicprofile/crm-cnt-basicprofile-list/div/div[4]/div/table/tbody/tr/td/span")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,600)");
            Thread.Sleep(3000);
            driver.Close();
        }

        [Test]
        public void ЗапишиВистинскиСопственик()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Запиши вистински сопственик")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ЗАПИШИ ВИСТИНСКИ СОПСТВЕНИК", driver.FindElement(By.XPath("//*[@id=\"mainheader\"]/div/div")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Упис на вистински сопственик на субјект")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='service']/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ПромениПодатоциНаСубјект()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Промени податоци за субјект")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ПРОМЕНИ ПОДАТОЦИ ЗА СУБЈЕКТ", driver.FindElement(By.XPath("//*[@id=\"mainheader\"]/div/div")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Проверка и резервација на име на субјект")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Проверка и резервација на име на правен субјект", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Самостојна промена на субјект")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Самостојна пријава за упис на промена во Трговски Регистар и Регистарот на Други Правни Лица", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("ДОО, ДООЕЛ")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div/a/i/i")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Пријава за упис на промена во Трговски Регистар и Регистарот на Други Правни Лица преку Регистрационен агент", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"servicesel\"]/div[2]/div[2]/div[2]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Статус на обработка на пријава поднесена во Централниот Регистар", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Close();

        }
      
        [Test]
        public void МапаНаУслуги()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Мапа на услуги")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,10000)");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Вести")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div/div/div/div/div/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div/div/div/div/div/crm-dropdown/aside/aside/fieldset/span/span[2]/span[2]/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div[2]/div/div/div/div/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div[2]/div/div/div/div/crm-dropdown/aside/aside/fieldset/span/span[2]/span[5]/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div[2]/div/div/div/div[2]/fieldset/span/select")).Click();
            Thread.Sleep(2000);
            new SelectElement(driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div[2]/div/div/div/div[2]/fieldset/span/select"))).SelectByText("2023");
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,600)");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/cms-template-news/cms-cnt-news/cms-cnt-news-list/div/div[2]/div/div/div/div[3]/button")).Click();
            driver.Close();
        }
        [Test]
        public void ГодишнаСметка()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Поднеси годишна сметка и финансиски извештај")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ПОДНЕСИ ГОДИШНА СМЕТКА И ФИНАНСИСКИ ИЗВЕШТАЈ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"servicesel\"]/div[2]/div[1]/div[1]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на годишна сметка во електронска форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"servicesel\"]/div[2]/div[1]/div[2]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на годишна сметка во хартиена форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Трговски друштва")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicecont']/crm-cnt-service-variation-general/div/div/div/div/label[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicecont']/crm-cnt-service-variation-general/div/div/div/div/label[3]")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"servicesel\"]/div[2]/div[2]/div[1]")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на консолидирана годишна сметка во електронска форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id=\"servicesel\"]/div[2]/div[2]/div[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='service']/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на консолидирана годишна сметка во хартиена форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[3]/div/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на ревизорски извештај во електронска форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[3]/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Поднесување на ревизорски извештај во хартиена форма", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ОбезбедиПобарување()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Обезбеди побарување")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ОБЕЗБЕДИ ПОБАРУВАЊЕ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на заложно право врз подвижни предмети и права", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicecont']/crm-cnt-service-variation-general/div/div/div/div/label[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicecont']/crm-cnt-service-variation-general/div/div/div/div/label[3]")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на промена на заложно право врз подвижни предмети и права", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Бришење на залог")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Бришење на заложно право врз подвижни предмети и права", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на правото на лизинг врз подвижни и недвижни предмети", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Промена на лизинг")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на промена на правото на лизинг врз подвижни и недвижни предмети", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Бришење на лизинг")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Бришење на правото на лизинг врз подвижни и недвижни предмети", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Упис на фидуција")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на договор за фидуцијарен пренос на правото на сопственост врз подвижни предмети и права", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Промена на фидуција")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на промена на договор за фидуцијарен пренос на правото на сопственост во Фидуцијарен регистар", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,600)");
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Бришење на фидуција")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Бришење на договор за фидуцијарен пренос врз подвижни предмети и права", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,600)");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Упис на продажба со задржување на сопственост")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на договор за продажба на подвижни ствари со задржување на правото на сопственост", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,800)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[6]/div/a/i")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на промена на договорот за продажба на подвижни ствари со задржување на правото на сопственост", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,800)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[6]/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на промена на договорот за продажба на подвижни ствари со задржување на правото на сопственост", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollTo(0,800)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[7]/div/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Статус на обработка на пријава поднесена во Централниот Регистар", driver.FindElement(By.XPath("//div[@id='service']/div/div/div/div/h2")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ИнвестицииИВложувања()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Пријави инвестиции и вложувања")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ПРИЈАВИ ИНВЕСТИЦИИ И ВЛОЖУВАЊА", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Пари, права, предмети")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Пари, права, предмети", driver.FindElement(By.LinkText("Пари, права, предмети")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Заеми")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Заеми", driver.FindElement(By.LinkText("Заеми")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Подружници")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Подружници", driver.FindElement(By.LinkText("Подружници")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Упис на вложување во недвижност")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Промени и бришење на вложување во недвижност")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Статус на обработка на предмет")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            driver.Close();
        }
        [Test]
        public void ИзбришиСубјектИПревземање()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Избриши субјект")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ИЗБРИШИ СУБЈЕКТ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Самостојно изведување на ликвидација на правно лице во фази", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div/a/h3")).Text);
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Ликвидација на правно лице во фази преку Регистрационен агент", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Text);
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Самостојно бришење и скратена ликвидација", driver.FindElement(By.LinkText("Самостојно бришење и скратена ликвидација")).Text);
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Бришење и скратена ликвидација преку Регистрационен агент", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div[2]/a/h3")).Text);
            Thread.Sleep(1000);
            ClassicAssert.AreEqual("Статус на обработка на предмет", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[3]/div/a/h3")).Text);
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Самостојно изведување на ликвидација на правно лице во фази")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='service']/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,3000)");
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("ПБ образец - Пријава за упис на бришење на субјектите запишани во Трговскиот регистар и Регистарот на други правни лица")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[2]/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div[3]/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ОстанатиУписиИОбврски()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("uslugi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Останати уписи или обврски")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ОСТАНАТИ УПИСИ ИЛИ ОБВРСКИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис во Адресен регистар", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div/a/h3")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Статус на обработка на предмет", driver.FindElement(By.XPath("//div[@id='servicesel']/div[2]/div/div[2]/a/h3")).Text);
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Упис на вистински сопственик на субјект")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='service']/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("Упис на вистински сопственик на субјект", driver.FindElement(By.LinkText("Упис на вистински сопственик на субјект")).Text);
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void Регистрација()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Регистрирај се")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://e-submit.crm.com.mk/SSO/Register.aspx");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtName")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtName")).Clear();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtName")).SendKeys("Darko");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSurname")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSurname")).Clear();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSurname")).SendKeys("Gjorgjievski");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtIdentifier")).Click();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtIdentifier")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtIdentifier")).SendKeys("0000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtEmail")).Click();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtEmail")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtEmail")).SendKeys("darko.gjorgjievski@gmail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPhoneNumber")).Click();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPhoneNumber")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPhoneNumber")).SendKeys("0700000");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_DdlCountry")).Click();
            Thread.Sleep(2000);
            new SelectElement(driver.FindElement(By.Id("cphMain_UcRegister1_DdlCountry"))).SelectByText("МАКЕДОНИЈА");
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,500)");
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPassword")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPassword")).Clear();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtPassword")).SendKeys("123456");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtRepeatPassword")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtRepeatPassword")).Clear();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtRepeatPassword")).SendKeys("123456");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSecretAnswer")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSecretAnswer")).Clear();
            driver.FindElement(By.Id("cphMain_UcRegister1_TxtSecretAnswer")).SendKeys("Semos");
            Thread.Sleep(2000);
            driver.Close();

        }
        [Test]
        public void ПребарувањеСоЕМБС()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div/a/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("embsCtrl")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("embsCtrl")).Clear();
            driver.FindElement(By.Name("embsCtrl")).SendKeys("5628083");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-basicprofile/crm-cnt-basicprofile/crm-cnt-basicprofile-list/div/div[3]/div/div[3]/div/button")).Click();
            Thread.Sleep(10000);
            driver.Close();
        }
        [Test]
        public void ПребарувањеПрекуНазив()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("partOfName")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("partOfName")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("partOfName")).SendKeys("DOOEL");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-latestannouncement/crm-cnt-latestannouncement/crm-cnt-latestannouncement-list/div/crm-cnt-latestannouncement-list-oss/div[2]/div/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,400)");
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void СтатистичкиБилтен()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[4]/a/h3")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div/div[2]/fieldset/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div/div[2]/fieldset/crm-dropdown/aside/aside/fieldset/span/span/span/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[2]/div/fieldset/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[2]/div/fieldset/crm-dropdown/aside/aside/fieldset/span/span/span[4]/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[2]/div[2]/fieldset/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[2]/div[2]/fieldset/crm-dropdown/aside/aside/fieldset/span/span/span/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[3]/div/fieldset/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[3]/div/fieldset/crm-dropdown/aside/aside/fieldset/span/span/span/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[3]/div[2]/fieldset/crm-dropdown/aside/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div/div[3]/div[2]/fieldset/crm-dropdown/aside/aside/fieldset/span/span/span/label")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='content']/cms-container/crm-template-fs-statisticalbulletin/crm-cnt-statisticalbulletin/div[2]/div[4]/div/div[2]/div/button")).Click();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ОтворениПодатоци()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[3]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ПОМОШ ПРИ ТОЛКУВАЊЕ НА ОБЈАВИТЕ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[5]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("СТАТУС НА ОБРАБОТКА НА ПРИЈАВА ЗА УПИС", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[6]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ГРАЃАНСКИ ОРГАНИЗАЦИИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/otvoreni-podatotsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_1']/div/div/div[7]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ИНФОРМАЦИИ ОД ЈАВЕН КАРАКТЕР", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Close();
        }
        [Test]
        public void ПрофесионалниКорисници()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("АДВОКАТИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[2]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("НОТАРИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[3]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("СТЕЧАЈНИ УПРАВНИЦИ, МЕ И СУДОВИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[4]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("СМЕТКОВОДИТЕЛИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[5]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("НОВИНАРИ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[6]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ДАВАТЕЛИ НА ЛИЗИНГ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/profesionalni-korisnitsi")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@id='DivMenuCont_2']/div/div/div[7]/a/h3")).Click();
            Thread.Sleep(2000);
            ClassicAssert.AreEqual("ОПШТИНИ И ГРАД СКОПЈЕ", driver.FindElement(By.XPath("//div[@id='mainheader']/div/div/div/h1")).Text);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            driver.Close();
        }
       
        [Test]
        public void Видео()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/za-tsrrsm")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Информативни материјали - Помош за корисници при користење на системите и услугите")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"content\"]/cms-container/cms-template-html/cms-cnt-html/div[2]/div/div/figure[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"content\"]/cms-container/cms-template-html/cms-cnt-html/div[2]/div/div/figure[1]")).Click();
            Thread.Sleep(2000);
            driver.Close();

        }
        [Test]
        public void ПроменаНаЈазик()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//header[@id='header']/div[2]/section/aside/a/img")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/section/aside/aside/ul/li[2]/a/img")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"header\"]/div[2]/section/aside/aside/ul/li[3]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Macedonian")).Click();
            Thread.Sleep(3000);
            driver.Close();
          
        }
        [Test]
        public void ЈавниНабавки()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Name("mk/za-tsrrsm")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Јавни набавки")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Објавени огласи")).Click();
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("https://e-nabavki.gov.mk/InstitutionGridData.aspx#/ciAnnouncementsGrid/5c4d0ad3-ac5d-452e-b1b4-b0f823be9ea9");
            Thread.Sleep(2000);
            var tabs = driver.WindowHandles; 
            if (tabs.Count > 1)
            Thread.Sleep(2000);
            { driver.SwitchTo().Window(tabs[1]);
            Thread.Sleep(2000);
            driver.Close();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(tabs[0]); }
            driver.Close();
        }
        [Test]
        public void ПребарувањеНаСтраницата()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.crm.com.mk/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[2]/div/a[2]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='text']")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("Адвокати");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            Thread.Sleep(3000);

            driver.Close();
        }
    }
    
}
