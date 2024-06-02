using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit; // Namespace của lớp PhuongTrinhBac1
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        "|DataDirectory|\\Data\\testDataPTB1.csv",
        "testDataPTB1#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPTBAC1()
        {
            // Lấy dữ liệu từ tệp CSV
            int a = Convert.ToInt32(TestContext.DataRow["a"]);
            int b = Convert.ToInt32(TestContext.DataRow["b"]);
            string expected = Convert.ToString(TestContext.DataRow["expected"]);

            // Tạo đối tượng PhuongTrinhBac1
            var pt = new PhuongTrinhBac1(a, b);

            // Giải phương trình
            var result = pt.GiaiPhuongTrinh();

            // Kiểm tra kết quả
            Assert.AreEqual(expected, result);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "D:\\tester-aws\\tester-aws\\Unit\\UnitTestProject\\Data\\testDataPTB2.csv",
                "testDataPTB2#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void testPtbac2()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            string expected1Str = TestContext.DataRow[3].ToString();
            string expected2Str = TestContext.DataRow[4].ToString();
            string exception = TestContext.DataRow[5].ToString();

            var pt = new PhuongTrinhBac2(a, b, c);

            if (!string.IsNullOrEmpty(exception))
            {
                Assert.ThrowsException<Exception>(() => pt.GiaiPhuongTrinh(), exception);
            }
            else
            {
                string result = pt.GiaiPhuongTrinh();

                // Kiểm tra kết quả trả về từ phương thức GiaiPhuongTrinh()
                // và so sánh với các giá trị mong đợi
                if (!string.IsNullOrEmpty(exception))
                {
                    Assert.ThrowsException<Exception>(() => pt.GiaiPhuongTrinh(), exception);
                }
                else
                {
                    var resultPt2 = pt.GiaiPhuongTrinh();

                    if (result.Contains("vo nghiem"))
                    {
                        // Kiểm tra kết quả là 'Phuong trinh vo nghiem'
                        Assert.AreEqual("Phuong trinh vo nghiem", expected1Str);
                    }
                    else if (result.Contains("vo so nghiem"))
                    {
                        // Kiểm tra kết quả là 'Phuong trinh vo so nghiem'
                        Assert.AreEqual("Phuong trinh vo so nghiem", expected1Str);
                    }
                    else
                    {
                        // Kiểm tra kết quả là các nghiệm được tính toán
                        double expected1 = double.Parse(expected1Str);
                        double expected2 = double.Parse(expected2Str);
                       
                    }
                }

            }
        }
    }
}
