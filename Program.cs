using System;

namespace Recursive_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif-Öz yinelemeli
            //3^4= 3*3*3*3

            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result *= 3;
            }
            Console.WriteLine(result);
            Islemler instance = new();
            Console.WriteLine(instance.Exponential(3, 4));
            //Extension Metotlar
            string ifade = "Mehmet Ateş Özateş";
            bool sonuc = ifade.CheckSpaces();
            Console.WriteLine(sonuc);
            if (sonuc)

                Console.WriteLine(ifade.RemoveWhiteSpaces());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());

        }

    }
    public class Islemler
    {

        public int Exponential(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;

            return Exponential(sayi, üs - 1) * sayi;
        }
    }

    public static class Extension
    {

        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {

            string[] dizi = param.Split(" ");
            // Bu string'i boşluklara göre ayırıp diziye atar.
            return string.Join("_", dizi);
            //string'leri boşluk olmadan birleştirir.
        }
        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();
            //Büyük harflerden oluşturacak şekilde kelimeyi yazdır.

        }

        public static string MakeLowerCase(this string param)
        {

            return param.ToLower();
            //Küçük harflerden oluşturacak şekilde kelimeyi yazdır.
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param)
        {

            foreach (int item in param)
                Console.WriteLine(item);

        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param){

            return param.Substring(0,1);
        }

    }
}



