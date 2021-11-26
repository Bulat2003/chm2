using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main()
        {
                double h = 0.06;
                double[] Xarray = new double[6] { -1, -0.925, -0.85, -0.775, -0.7, -0.625 };
                int n = 3;
                double[] x = new double[3];
                double[] y = new double[3];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите значение X ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    x[i] = Math.Round(a, 3);
                    y[i] = Math.Round(12 * x[i] * Math.Sqrt(Math.Pow(x[i], 3) + 1));
                }

                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("| x| y(x)| PI(x)| |y(x)-PI(x)|| PII(X)| |y(x)-PI(x)| L(x)| |y(x)-L(x)| ");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine();

                for (int i = 0; i < n; i++)
                {
                    double q = (x[i] - Xarray[0]) / h;
                    double PI = 0 + 0.28816 * q - 0.29755 * q * (q - 1) / 2 - 0.15622 * q * (q - 1) * (q - 2) / 6 - 0.19394 * q * (q - 1) * (q - 2) * (q - 3) / 24 - 2.4539 * q * (q - 1) * (q - 2) * (q - 3) * (q - 4) / 120;
                    double t = (x[i] - Xarray[5]) / h;
                    double PII = Math.Round(-6.52051 - 5.06903 * t + 3.80194 * t * (t + 1) / 2 - 2.99801 * t * (t + 1) * (t + 2) / 6 + 2.64785 * t * (t + 1) * (t + 2) * (t + 2) * (t + 3) / 24 - 2.4539 * t * (t + 1) * (t + 2) * (t + 3) * (t + 4) / 120, 10);
                    double L = Math.Round(0 * (x[i] - Xarray[1]) * (x[i] - Xarray[2]) * (x[i] - Xarray[3]) * (x[i] - Xarray[4]) * (x[i] - Xarray[5]) + (-89003.54) * (x[i] - Xarray[0]) * (x[i] - Xarray[2]) * (x[i] - Xarray[3]) * (x[i] - Xarray[4]) * (x[i] - Xarray[5]) + 2125824.64 * (x[i] - Xarray[0]) * (x[i] - Xarray[1]) * (x[i] - Xarray[3]) * (x[i] - Xarray[4]) * (x[i] - Xarray[5]) + (-2387675.829) * (x[i] - Xarray[0]) * (x[i] - Xarray[1]) * (x[i] - Xarray[2]) * (x[i] - Xarray[4]) * (x[i] - Xarray[5]) + 1195486.63 * (x[i] - Xarray[0]) * (x[i] - Xarray[1]) * (x[i] - Xarray[2]) * (x[i] - Xarray[3]) * (x[i] - Xarray[5]) + (228978.1289) * (x[i] - Xarray[0]) * (x[i] - Xarray[1]) * (x[i] - Xarray[2]) * (x[i] - Xarray[3]) * (x[i] - Xarray[4]), 10);
                    Console.WriteLine("| " + x[i] + "| " + y[i] + "| " + PI + "| " + Math.Round(Math.Abs(y[i] - PI), 10) + "| " + PII + "| " + Math.Round(Math.Abs(y[i] - PII), 10) + "| " + L + "| " + Math.Abs(y[i] - L) + "|");
                }
        }
    }
}