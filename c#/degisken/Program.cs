using System;

namespace degisken
{
    class Program
    {
        static void Main(string[] args)
        {
            int deger;
            deger = 2;

            // string degisken = null;
            // string Degisken = null;
            // int 3Degisken = null; Hatali

            String degisken = " ";

            byte b = 5; // 1 byte
            ushort us = 5; //2 byte 0-65365 arasinda deger alir

            Int16 i16 = 2; //2 byte
            int i = 2; // 4 byte
            Int32 i32 = 2; //4 byte
            Int64 i64 = 2; //8 byte


            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8 byte

            float f = 5; //4 byte
            double d = 5; //8 byte
            decimal de = 5; //16 byte

            char c = '2'; // 2 byte
            string str = "Faruk"; //Sinirsiz
            
            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            System.Console.WriteLine(dt);

            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.2;

            // string

            string str1 = string.Empty;
            string ad = "Faruk";
            string soyad = "Ipek";
            string tamIsim = ad + soyad;

            //integer
            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            //boolean
            bool b3 = 10 < 2; // false


            //degisken donusumleri
            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            System.Console.WriteLine(yenideger); //Ciktisi 2020

            int int21 = int20 + Convert.ToInt32(str20);
            System.Console.WriteLine(int21); //Ciktisi 40

            int int22 = int20 + int.Parse(str20);
            System.Console.WriteLine(int22); //Ciktisi 40

            //datetime

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime); //tarihi noktali sekilde verir
            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);
            
        }
    }
}
