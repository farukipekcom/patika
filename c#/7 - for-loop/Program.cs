using System;

namespace _7___for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayiya kadar olan sayilari ekrana bas
            System.Console.Write("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for(int i = 1; i <= sayac; i++) {
                if(i % 2 == 1){
                    System.Console.WriteLine(i);
                }
            }
            // 1 - 1000 arasindaki tek ve cift sayilarin kendi iclerindeki toplamlari ekrana yazdir
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1; i <= 1000; i++) {
                if(i % 2 == 1){
                    tekToplam += i;
                }
                else {
                    ciftToplam += i;
                }
            }
            System.Console.WriteLine("Tek Sayilarin Toplami: " + tekToplam);
            System.Console.WriteLine("Cift Sayilarin Toplami: " + ciftToplam);

            for(int i = 1; i < 10; i++) {
                if(i == 4) {
                    break; //4'e gelince for'dan cikti
                }
                System.Console.WriteLine(i);
            }

            for(int i = 1; i < 10; i++) {
                if(i == 4) {
                    continue; //4u gorunce atladi
                }
                System.Console.WriteLine(i);
            }

            
        }
    }
}
