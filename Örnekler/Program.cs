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
            Console.WriteLine("İsminizi Girdiğiniz Kadar Yazdıran Program (Soru 1)\n");
            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();
            Console.Write("İsminiz Kaç Kere Yazılsın : ");
            int tekrar = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= tekrar; i++)
            {
                Console.WriteLine(isim);
            }
            Console.WriteLine("\n\nDiğerine Geçmek İçin Her Hangi Bir Tuşa Basınız\n\n");
            Console.ReadKey();




            Console.WriteLine("Hesap Makinesi (Soru 2)\n");
            int sonuc = 0;

            Console.Write("1. Sayıyı Giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nİşlem Seçiniz \n---------------\n + , - , * , /");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (islem == "-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == "*")
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == "/")
            {
                sonuc = sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Yanlış İşlem Seçtiniz");
            }

            Console.WriteLine("Sonuç : " + sonuc);
            Console.WriteLine("\n\nDiğerine Geçmek İçin Her Hangi Bir Tuşa Basınız\n\n");
            Console.ReadKey();





            Console.WriteLine("Üçgenin 3. İç Açısını Bulan Program (Soru 3)\n");
            Console.Write("Üçgenin 1. İç Açısını Giriniz : ");
            int icaci1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçgenin 2. İç Açısını Giriniz : ");
            int icaci2 = Convert.ToInt32(Console.ReadLine());

            int icaci3 = 180 - icaci1 - icaci2;

            Console.WriteLine("Üçgenin 3. İç Açısı : " + icaci3);
            Console.WriteLine("\n\nDiğerine Geçmek İçin Her Hangi Bir Tuşa Basınız\n\n");
            Console.ReadKey();
        }
    }
}
