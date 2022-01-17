using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {   //Odev-1.soru
            /*Console.WriteLine("Pozitif bir sayı giriniz.");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" Adet Pozitif tam sayı giriniz.");
            int num;

            int[] nums =new int[n];
            for(int i=0; i<n; i++)
            {
             num=Convert.ToInt32(Console.ReadLine());
             nums[i]=num;

            }

            foreach(int value in nums)
            {
                if(value%2==0)
                {
                    Console.WriteLine("Girilen çift sayı: "+value);
                }

            }*/

            //Odev-2.soru
            /*Console.Write("Pozitif iki sayi giriniz ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet sayi giriniz", n);
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine("{0}.Sayıyı Giriniz;", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
               if ((sayi == m) || (sayi % m == 0))
                {

                   Console.WriteLine("Tam bölünüyor " + sayi);
       /        }
            }*/

            //Odev-3.Soru

            /*List<string> kelimeler = new List<string>();
            Console.Write("Pozitif bir sayi giriniz ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} adet kelime giriniz", n);
            for (int i = 0; i < n; i++)
            {
               Console.WriteLine("{0}.Kelimeyi Giriniz;", i + 1);
                string kelime = Console.ReadLine();
               kelimeler.Add(kelime);
            }
            int son = kelimeler.Count - 1;
            Console.WriteLine("---sondan başa doğru kelimeler---");
            for (int i = son; i >= 0; --i)
            {
                Console.WriteLine(kelimeler[i]);
            }*/

            //Odev 4.Soru
            /*Console.WriteLine("Bir cümle giriniz .");
            string cumle = Console.ReadLine();
            string liste = "ABCÇDEFGĞHİIJKLMNOÖPRSŞTUÜVYZ"
                      + "abcçdefgğhiıjklmnoöprsştuüvyz";
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);

            int sayac = 0;
            for (int i = 0; i < cumle.Length; i++)
            {
                //karakter katarkter kontrol ediyoruz.
                if (liste.Contains(cumle[i]))
                {
                    sayac++;
                }
            }
            Console.WriteLine("toplam {0} tane  harf vardır.", sayac);*/

            Console.ReadLine();

        }
    }
}
