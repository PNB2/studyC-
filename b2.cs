using System;
namespace VietTutsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            Console.Write("Nhap he so bac 2, a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Nhap he so bac 1, b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Nhap so hang tu do, c = ");
            c = float.Parse(Console.ReadLine());
            giaiPTBac2(a, b, c);
 
            Console.WriteLine();
            Console.ReadKey();
        }
 
 
        /**
          * giai phuong trinh bac 2: ax2 + bx + c = 0
          * 
          * @param a: he so bac 2
          * @param b: he so bac 1
          * @param c: so hang tu do
          */
        static void giaiPTBac2(float a, float b, float c)
        {
            // kiem tra cac he so
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem!");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co mot nghiem: x = {0}", (-c / b));
                }
                return;
            }
            // tinh delta
            float delta = b * b - 4 * a * c;
            float x1;
            float x2;
            // tinh nghiem
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine("Phuong trinh co 2 nghiem la: x1 = {0} va x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.WriteLine("Phong trinh co nghiem kep: x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
        }
    }
}
