﻿using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //atama ve islemli atama
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            y *= 2;
            Console.WriteLine(y);

            //mantiksal operatorler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!"); 

            if(isSuccess || isCompleted)
            Console.WriteLine("Great!"); 

            if(isSuccess || !isCompleted)
            Console.WriteLine("Fine!"); 

            //iliskisel operatorler
            // <,>, <=, >=, !=, ==
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);

            //aritmetik operatorler
            // /, +, -, *
            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2 = sayi1 * sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3 = sayi1 + sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4 = sayi1 - sayi2;
            Console.WriteLine(sonuc4);

            // % operatoru. mod alir
            int modislemi = 20 % 3;
            Console.WriteLine(sonuc2);
        }
    }
}
