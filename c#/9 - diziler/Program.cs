using System;

namespace _9___diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanimlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi", "Kopek", "Kus", "Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere deger atama ve erisim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            
            Console.WriteLine(hayvanlar[0]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            //Dongulerle dizi kullanimi
            //klavyeden girilen n tane sayinin ortalamasini alan uygulama

            System.Console.WriteLine("Lutfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for(int i = 0; i < diziUzunlugu; i++){
                Console.Write("Lutfen {0}. sayiyi giriniz", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(int item in sayiDizisi){
                toplam += item;
            }
            System.Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);
            
        }
    }
}
