using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Circle.L();
                Circle.S();
                Circle.XY();
            }
            catch
            {
                Console.WriteLine("Oshibka! Vhodnay stroka imela nevernii format");
            }
            Console.ReadKey();
        }
    }


    public static class Circle
    {
        public static double x0;
        public static double y0;
        public static double x;
        public static double y;
        static double r;

        public static double R
        {
            set
            {
                if (value > 0)
                {
                    r = value;
                }
                else
                {
                    Console.WriteLine("Radius dolgen bit' >0");
                }
            }
            get
            {
                return r;
            }
        }
        static Circle()
        {
            Console.Write("Vvedite znachenie koordonatu centra okrugnosti x0 ");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite znachenie koordonatu centra okrugnosti y0 ");
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite znachenie radiusa r ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite koordinatu tochki x ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Vvedite koordinatu tochki y ");
            y = Convert.ToDouble(Console.ReadLine());
        }
        static public void L()
        {
            Console.WriteLine("Dlina okrugnosti {0:0.00}", 2*Math.PI*r);
        }
        static public void S()
        {
            Console.WriteLine("Ploshad' kruga {0:0.00}",Math.PI * r*r);
        }
        static public void XY()
        {
            if (r==Math.Sqrt((x-x0)* (x - x0)+(y-y0)* (y - y0)))
            {
                Console.WriteLine("Tochka c koordinatani (x,y) prinadlegit okrugnosti");
            }
            else
            {
                Console.WriteLine("Tochka c koordinatani (x,y) ne prinadlegit okrugnosti");
            }
        }
    }
}
