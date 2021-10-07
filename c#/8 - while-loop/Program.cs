using System;

namespace _8___while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1den baslayarak konsoldan girilen sayiya kadar(sayi dahil) ortalama hesaplayip konsola yazan uygulama
            System.Console.Write("Bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while(sayac <= sayi) {
                toplam += sayi;
                sayac++;
            }
            System.Console.WriteLine("Toplam: " + toplam);

            //a'dan z'ye kadar tum harfleri ekrana yaz
            char character = 'a';
            while(character <= 'z') {
                System.Console.Write(character);
                character++;
            }
            System.Console.WriteLine();
            string[] arabalar = {"A", "B", "C", "D", "E"};
            foreach(var item in arabalar) {
                System.Console.WriteLine(item);
            }
        }
    }
}
