using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Unit;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "D:\\tester-aws\\tester-aws\\Unit\\UnitTestProject\\Data\\TestNgayTrongNam.csv",
        "TestNgayTrongNam#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestNgayThuBaoNhieuTrongNam()
        {
            // Lấy dữ liệu từ tệp CSV
            int ngay = Convert.ToInt32(TestContext.DataRow["ngay"]);
            int thang = Convert.ToInt32(TestContext.DataRow["thang"]);
            int nam = Convert.ToInt32(TestContext.DataRow["nam"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            var ntn = new NgayTrongNam(ngay, thang, nam);

            // Tính ngày thứ bao nhiêu trong năm
            int result = ntn.TimNgayThuBaoNhieuTrongNam();

            // Kiểm tra kết quả
            Assert.AreEqual(expected, result);
        }
    }
}
