using CommonEntities.DataType;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonEntities.Test.DataType
{
    [TestClass]
    public class UrlTest
    {
        [TestMethod]
        public void Assert_UrlAsText_EqualsString()
        {
            URL url = new URL("https://makanal.eu");
            Assert.AreEqual(url.AsText, "https://makanal.eu");
        }
    }
}
