using System;

namespace PRG2_20192_P1_3_07
{
    class Program
    {
        static void Main()
        {
            Console.Write("Masukan banyak anak ayam : ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ANAK AYAM TURUN {0}", N);

            for(int i=N; i>=1; i--)
            {
                if (i == 1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", i);
                }
                else
                {
             
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {0}", i, i - 1);
                }
                
            }
        }
    }
}
