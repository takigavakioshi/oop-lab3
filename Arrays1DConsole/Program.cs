using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {


                Console.WriteLine("Веденно не правильно даннi");

            }

            double[] arr = new double[100];
            Random rnd = new Random();
            for (int i=0; i<n; i++)
            {
                
                
                   
                    arr[i] = Convert.ToDouble(rnd.Next(-156, 543) / 10.0);
                    Console.Write("{0, 10}",arr[i]);
                
                
            }
            Console.WriteLine();
            Console.WriteLine();
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
               
                    double array = arr[i];
                    if  ((array*10)%10 >=5) { sum += Math.Abs(arr[i]);}
                
            }

            Console.WriteLine("suma={0}",sum);
            Console.WriteLine();
            Console.WriteLine();
            int imin;
            double a;
            for (int i = n / 2; i < n - 1; i++)
            {
                imin = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[imin])
                    {
                        imin = j;
                        a = arr[i];
                        arr[i] = arr[imin];
                        arr[imin] = a;
                    }
                    
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {



               
                Console.Write("{0, 10}", arr[i]);


            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
