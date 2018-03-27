using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2DConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            int n,m;
            while (!int.TryParse(Console.ReadLine(), out m))
            {


                Console.WriteLine("Веденно не правильно даннi");

            }
            while (!int.TryParse(Console.ReadLine(), out n))
            {


                Console.WriteLine("Веденно не правильно даннi");

            }

            double[,] arr = new double[100, 100];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    arr[i, j] = Convert.ToDouble(rnd.Next(-28305, 12951) / 1000.000);
                    Console.Write("{0, 10}", arr[i, j]);

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            double sum = 0;
            double min = 10000,max=-10000;
            double[] ar = new double[100];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min > arr[i, j]) min = arr[i, j];
                }
                ar[i] = min;
                min = 10000;
            }
            for (int i = 0; i < n; i++)
            {
                if (max < ar[i]) { max = ar[i]; };
                Console.Write("{0,8}", ar[i]);
            }
            Console.WriteLine();
            Console.WriteLine("max from min={0}", max);
            double temp;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {  temp = arr[i, j];
                    if (arr[i, j] < 0)
                    {
                       
                            temp = arr[i,n-1];
                            for (int k = n-1; k > 1; k--)
                                arr[i,k] = arr[i,k - 1];
                            arr[i,1] = temp;
                        
                    }
                }
                
            }
            Console.WriteLine();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                 
                    Console.Write("{0, 10}", arr[i, j]);

                }
                Console.WriteLine();
            }
            
           
            Console.ReadKey();
        }
    }
}
