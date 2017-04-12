using MyChudoFrame.PageObject;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyChudoFrame.Forms
{
    public class YandexMarketMainForm : BaseForm
    {
        private readonly static By _TitleLocator = By.XPath("//div[@class='n-box n-box_type_promo n-box_type_custom-color']");
        private TextBox _tbFound = new TextBox(By.Id("header-search"));
        private Button _btFound = new Button(By.XPath("//button[@type='submit']"));
        private Link _lkPrice = new Link(By.XPath("//div[@class='price']"));
        private Link _lkFirstSearchResult = new Link(By.XPath("//span[@class='snippet-card__header-text']"));

        public YandexMarketMainForm() : base(_TitleLocator) { }

        public void CheckProductSearch()
        {
            _tbFound.SendKey(GetDataFromExel(1, 1));
            _btFound.Click();

            Assert.IsTrue(_lkFirstSearchResult.GetText().Contains(GetDataFromExel(1,1)));

            Assert.IsTrue(_lkPrice.GetText().Contains(GetDataFromExel(1, 2)));

        }
    }
}
