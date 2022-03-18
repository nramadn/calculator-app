using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int pilihan;

            Console.WriteLine(" Pilih Menu Calculator");
            Console.WriteLine(" 1. Penjumlahan");
            Console.WriteLine(" 2. Pengurangan");
            Console.WriteLine(" 3. Perkalian");
            Console.WriteLine(" 4. Pembagian");

            Console.Write("Input Nomor Menu [1..4] : ");
            pilihan = int.Parse(System.Console.In.ReadLine());

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Inputkan nilai b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Hasil Penjumlahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:
                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("Hasil Perkalian   {0} * {1} = {2}", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("Hasil Pembagian   {0} / {1} = {2}", a, b, Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia!!");
                    break;
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }
        static int Pengurangan(int a, int b)
        {
            return a - b;
        }
        static int Perkalian(int a, int b)
        {
            return a * b;
        }
        static int Pembagian(int a, int b)
        {
            return a - b;
        }
    }
}