using System;

namespace _6___switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            //Exppression
            switch(month){
                case 1:
                    System.Console.WriteLine("Ocak");
                    break;
                case 2:
                    System.Console.WriteLine("Subat");
                    break;
                case 3:
                    System.Console.WriteLine("Mart");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan");
                    break;
                case 5:
                    System.Console.WriteLine("Mayis");
                    break;
                case 6:
                    System.Console.WriteLine("Hazira");
                    break;
                case 7:
                    System.Console.WriteLine("Temmuz");
                    break;
                case 8:
                    System.Console.WriteLine("Agustos");
                    break;
                case 9:
                    System.Console.WriteLine("Eylul");
                    break;
                case 10:
                    System.Console.WriteLine("Ekim");
                    break;
                case 11:
                    System.Console.WriteLine("Kasim");
                    break;
                case 12:
                    System.Console.WriteLine("Aralik");
                    break;

                default:
                    System.Console.WriteLine("Yanlis veri geldi!");
                break;
            }
            switch(month) {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kis ayindasiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("Ilkbahar ayindasiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("Yaz ayindasiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("Sonbahar ayindasiniz");
                    break;
                default:
                break;
            }
        }
    }
}
