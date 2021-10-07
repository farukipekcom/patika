using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     System.Console.WriteLine("Bir sayi giriniz: ");
            //     int sayi = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Girdiginiz Sayi: " + sayi); 
            // }
            // catch (Exception ex)
            // {
            //     System.Console.WriteLine("Hata: " + ex.Message.ToString());
            //     throw;
            // }
            // // finally{
            // //     System.Console.WriteLine("Islem tamamlandi!");
            // // }
            

            try
            {
                //  int a = int.Parse(null);
                //  int b = int.Parse("test");
                int c = int.Parse("-2000000");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("Bos deger girdiniz!");
                System.Console.WriteLine(ex);
            }
            catch(FormatException ex) {
                System.Console.WriteLine("Veri tip uygun degil");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                System.Console.WriteLine("Cok kucuk ya da cok buyuk deger girdiniz");
                System.Console.WriteLine(ex);
            }


            
        }
    }
}
