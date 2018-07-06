using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS
{
    class Program
    {
        static int sumX(int x, int n)
        {
            int a=0;
            if(x<=1000 && x>=-1000 && n<=1000 && n >= -1000)
            {
                if (x>0 && n>0) {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i % x == 0)
                        {
                            a = a + i;
                        }
                        else
                        {

                        }
                    }
                    return a;
                }
                else if(x<0 && n < 0)
                {
                    for (int i = -1; i >= n; i--)
                    {
                        if (i % x == 0)
                        {
                            a = a + i;
                        }
                        else
                        {

                        }
                    }
                    return a;

                }
                else if(x==0 || n == 0)
                {
                    a = 0;
                    
                }  return a;        
            }
            else
            {
                a = 0;
                return a;
            }
            
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Nilai n = ");
            int n = Console.Read();
            Console.WriteLine("Nilai x = ");
            int x = Console.Read();
            
           
            Console.WriteLine(("sumX(" + x +","+ n +"):") + sumX(x, n));
         
            Console.WriteLine("sumX(3, 10): " + (sumX(3, 10) == 18));
            Console.WriteLine("sumX(1, 10): " + (sumX(1, 10) == 55));
            Console.WriteLine("sumX(0, 10): " + (sumX(0, 10) == 1));
            Console.WriteLine("sumX(-1, 10): " + (sumX(-1, 10) == 0));
            Console.WriteLine("sumX(-1, -10): " + (sumX(-1, -10) == -55));
       
            Console.ReadKey();

        }
    }
}
