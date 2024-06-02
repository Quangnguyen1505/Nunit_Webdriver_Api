using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest2
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "D:\\tester-aws\\tester-aws\\Unit\\UnitTestProject\\Data\\HinhNon.csv",
        "HinhNon#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestTinhTheTich()
        {
            // Lấy dữ liệu từ tệp CSV
            double banKinhDay = Convert.ToDouble(TestContext.DataRow["banKinhDay"]);
            double chieuCao = Convert.ToDouble(TestContext.DataRow["chieuCao"]);
            double expectedTheTich = Convert.ToDouble(TestContext.DataRow["expectedTheTich"]);
            Console.WriteLine($"banKinhDay: {banKinhDay}, chieuCao: {chieuCao}, expectedTheTich: {expectedTheTich}");

            var hn = new HinhNon(banKinhDay, chieuCao);
            // Tính thể tích
            double resultTheTich = hn.TinhTheTich();

            // Kiểm tra kết quả
            Assert.AreEqual(expectedTheTich, resultTheTich, 0.01);
        }
    }
}
