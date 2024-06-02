using System;

namespace Unit
{
    public class PhuongTrinhBac1
    {
        private int a, b;

        // Constructor to initialize the coefficients
        public PhuongTrinhBac1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        // Method to solve the equation and return the result
        public string GiaiPhuongTrinh()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "Phuong trinh vo so nghiem";
                }
                else
                {
                    return "Phuong trinh vo nghiem";
                }
            }
            else
            {
                double nghiem = (double)-b / a;
                return $"Phuong trinh co nghiem: x = {nghiem}";
            }
        }
    }
}
