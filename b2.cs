using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// test case 1: x2 - 49x - 50 = 0 -> x1 = 50 x2 =-1
// test case 2: Giải phương trình x2 – 4x +4 = 0 -> x1 = x2 = 2
// test case 3: 3x2 + 2x + 5 = 0 -> vo nghiem
namespace bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a = ");
            Double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            Double b = double.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            Double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    }
                }
                else
                {
                    Double x = -c / b;
                    Console.WriteLine("Phuong trinh co nghiem duy nhat x = " + Math.Round(x,2));
                }
            }
            else
            {
                Double delta = Math.Pow(b, 2) - (4 * a * c);
                Double x1, x2;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                } else if (delta == 0)
                {
                    x1 = x2 = (-b / (2 * a));
                    Console.WriteLine("Phuong trinh nghiem kep: " + x1);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phuong trinh co hai nghiem phan biet: x1 = {0} va x2 = {1}", x1,x2);
                }
            }
        }
    }
}
