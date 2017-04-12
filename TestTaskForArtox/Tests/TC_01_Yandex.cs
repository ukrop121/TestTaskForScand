using MyChudoFrame.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyChudoFrame.Tests
{
    [TestClass]
    public class TC_01_Yandex : BaseTest
    {
        [TestMethod]
        public void TestCaseYandexMarket()
        {
            Logger.Info("Go to yandex market and check search");
            var yandexMarketMainForm = new YandexMarketMainForm();
            yandexMarketMainForm.CheckProductSearch();
        }
    }
}
