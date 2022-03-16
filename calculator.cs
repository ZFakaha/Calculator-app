using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10;
            //int b = 6;

            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine();
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
			
            menuawal:
            
			Console.WriteLine();
            Console.Write("Inputkan no menu : ");

            string menustring = Console.ReadLine();
            char menu = char.Parse(menustring); //proses casting ke char dari string

            Console.WriteLine();

            if (menu == '1')
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + penambahan(a, b));
            }
            else if (menu == '2')
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (menu == '3')
            {
                Console.Write("Inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine()); //proses casting   
                Console.Write("Inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }
            else if (menu == '4')
            {
                Console.Write("Inputkan nilai a = ");
                float a = int.Parse(Console.ReadLine()); //proses casting
                Console.Write("Inputkan nilai b = ");
                float b = Convert.ToInt32(Console.ReadLine()); //proses casting
                Console.WriteLine("Hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
            { Console.WriteLine("Input error! inputkan 1, 2, 3, atau 4");
                goto menuawal;
            } 

            Console.WriteLine(); //tambahkan baris kosong

            

            Console.WriteLine("\nTekan sembarang untuk keluar....");
            Console.ReadKey();
        }
        static int penambahan(int a, int b)
        { return a + b;
        }

        static int pengurangan(int a, int b)
        { return a - b;
        }

        static int perkalian(int a, int b)
        { return a * b;
        }

        static float pembagian(float a, float b)
        { return a / b;
        }

    }
}
