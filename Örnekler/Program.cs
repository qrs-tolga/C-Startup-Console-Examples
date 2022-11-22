using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program That Prints As You Enter Your Name (Example 1)\n");
            Console.Write("Name : ");
            string isim = Console.ReadLine();
            Console.Write("How Many Times Should Your Name Be Written : ");
            int tekrar = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= tekrar; i++)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("\n\nPress Any Key to Switch to Another\n\n");
            Console.ReadKey();




            Console.WriteLine("Calculator (Example 2)\n");
            int sonuc = 0;

            Console.Write("1. Enter Number : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Enter Number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect Transaction \n---------------\n + , - , * , /");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                sonuc = number1 + number2;
            }
            else if (islem == "-")
            {
                sonuc = number1 - number2;
            }
            else if (islem == "*")
            {
                sonuc = number1 * number2;
            }
            else if (islem == "/")
            {
                sonuc = number1 / number2;
            }
            else
            {
                Console.WriteLine("You Selected Wrong Transaction");
            }

            Console.WriteLine("Sonuç : " + sonuc);
            Console.WriteLine("\n\nPress Any Key to Switch to Another\n\n");
            Console.ReadKey();





            Console.WriteLine("Program to Find the 3rd Interior Angle of a Triangle(Example 3)\n");
            Console.Write("Enter the 1st Interior Angle of the Triangle : ");
            int icaci1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2st Interior Angle of the Triangle : ");
            int icaci2 = Convert.ToInt32(Console.ReadLine());

            int icaci3 = 180 - icaci1 - icaci2;

            Console.WriteLine("3rd Interior Angle of Triangle : " + icaci3);
            Console.WriteLine("\n\nPress Any Key to Switch to Another\n\n");
            Console.ReadKey();
        }
    }
}
