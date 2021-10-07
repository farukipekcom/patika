using System;

namespace _10___array
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] sayiDizisi = {23,12,4,86,3,11,17};
             foreach(var sayi in sayiDizisi) {
                 System.Console.Write(sayi + ",");
             }
             System.Console.WriteLine();
             Array.Sort(sayiDizisi);
             foreach(var sayi in sayiDizisi) {
                 System.Console.Write(sayi + ",");
             }
             System.Console.WriteLine();

             //Clear
             //2. indexten basla 2 tane elemani temizle
             Array.Clear(sayiDizisi,2,2);
             foreach(var sayi in sayiDizisi) {
                 System.Console.Write(sayi + ",");
             }

             System.Console.WriteLine();
             //Reverse
             Array.Reverse(sayiDizisi);
             foreach(var sayi in sayiDizisi) {
                 System.Console.Write(sayi + ",");
             }

             System.Console.WriteLine();
             //IndexOf
             int bulunanIndex = Array.IndexOf(sayiDizisi, 23);
             System.Console.WriteLine("Bulunan Index" + bulunanIndex);


             System.Console.WriteLine();
             //Resize
             Array.Resize<int>(ref sayiDizisi, 9);
             sayiDizisi[8] = 99;
             foreach(var sayi in sayiDizisi) {
                 System.Console.Write(sayi + ",");
             }
        }
    }
}
