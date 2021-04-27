using System;
using System.Windows.Forms;

namespace lab3
{
    public static class CheckFunc
    {
        public static bool CoordinateX(double leftBorder, double rightBorder, double x)
        {
            if (x <= rightBorder && x >= leftBorder)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Измените границы по оси Х или само значение Х");
                return false;
            }
        }

        public static bool InnerRoot (double coefA, double coefC, double x)
        {
            double y;
            y = Math.Pow(coefA, 4) + 4 * Math.Pow(coefC, 2) * Math.Pow(x, 2);
            if(y >= 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("При вычислении квадратного корня подкоренное выражение оказалось меньше 0. Измените входные данные");
                return false;
            }
        }

        public static bool ExternalRoot(double coefA, double coefC, double x)
        {
            double y;
            y = Math.Sqrt(Math.Pow(coefA, 4) + 4 * Math.Pow(coefC, 2) * Math.Pow(x, 2)) - Math.Pow(x, 2) - Math.Pow(coefC, 2);
            if(y >= 0)
            {
                return true; 
            }
            else
            {
                MessageBox.Show("При вычислении квадратного корня подкоренное выражение оказалось меньше 0. Измените входные данные");
                return false;
            }
        }

        public static bool CoordinateY (double lowerBorder, double upperBorder, double y)
        {
            if(y >= lowerBorder && y <= upperBorder)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Измените границы по оси Y или входные данные");
                return false;
            }
        }
    }
}
