using System;

namespace PRG2_20192_P1_4_07
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("MENU SEGITIGA SIKU SIKU");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Hipotenusa");
            Console.WriteLine("1. Hitung Keliling");
            Console.WriteLine("1. Keluar");

            Console.Write("Menu Pilihan : ");
            int opsi = Convert.ToInt16(Console.ReadLine());

            switch(opsi)
            {
                case 1: Program.hitungLuas(); break;
                case 2: Program.hitungHipo(); break;
                case 3: Program.hitungKel(); break;
                case 4: Console.WriteLine("Terimakasih"); break;
            }
        }

        static void hitungLuas()
        {
            Console.Write("Masukan alas : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi : ");
            double t = Convert.ToDouble(Console.ReadLine());

            double luas = 0.5 * a * t;
            Console.Write("Luas segitiga dengan alas {0} dan tinggi {1} adalah {2}cm^2 ", a, t, luas);
        }

        static void hitungHipo()
        {
            Console.Write("Masukan alas : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi : ");
            double t = Convert.ToDouble(Console.ReadLine());

            double hipo = Math.Sqrt((a * a) + (t * t));
            Console.Write("Hipotenusa segitiga dengan alas {0} dan tinggi {1} adalah {2}cm ", a, t, hipo);
        }

        static void hitungKel()
        {
            Console.Write("Masukan alas : ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukan tinggi : ");
            double t = Convert.ToDouble(Console.ReadLine());

            double hipo = Math.Sqrt((a * a) + (t * t));
            double kel = a + t + hipo;
            Console.Write("Keliling segitiga dengan alas {0} dan tinggi {1} adalah {2}cm ", a, t, kel);

        }

        
    }
}
