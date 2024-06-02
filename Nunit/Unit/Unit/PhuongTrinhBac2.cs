using System;

namespace Unit
{
    public class PhuongTrinhBac2
    {
        private int a, b, c;

        // Constructor to initialize the coefficients
        public PhuongTrinhBac2(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        // Method to solve the equation and return the result
        public string GiaiPhuongTrinh()
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                    double nghiem = (double)-c / b;
                    return $"Phuong trinh co nghiem: x = {nghiem}";
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    return "Phuong trinh vo nghiem";
                }
                else if (delta == 0)
                {
                    double nghiemKep = (double)-b / (2 * a);
                    return $"Phuong trinh co nghiem kep: x = {nghiemKep}";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    return $"Phuong trinh co hai nghiem: x1 = {x1}, x2 = {x2}";
                }
            }
        }
    }
}
