using System;

namespace _5___if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if(time >= 6 && time < 11) {
                System.Console.WriteLine("Gunaydin!");
            }
            else if(time <= 18) {
                System.Console.WriteLine("Iyi Gunler!");
            }
            else {
                System.Console.WriteLine("Iyi Geceler");
            }

            string sonuc = time <= 18 ? "Iyi Gunler!!" : "Iyi Geceler!!";

            sonuc = time >= 6 && time <= 11 ? "Gunaydin" : time <= 18 ? "Iyi Gunler" : "Iyi Geceler"; 
            
            System.Console.WriteLine(sonuc);
        }
    }
}
