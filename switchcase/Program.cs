using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kaçıncı aydasınız: ");
            string ay = Convert.ToString(Console.ReadLine());

            switch(ay)
            {
                case "a":
                    Console.WriteLine("ocak");
                    break;
                case "b":
                    Console.WriteLine("şubat");
                    break;
                case "c":
                    Console.WriteLine("mart");
                    break;
                case "4":
                    Console.WriteLine("nisan");
                    break;
                case "5":
                    Console.WriteLine("mayıs");
                    break;
                case "6":
                    Console.WriteLine("haziran");
                    break;
                case "7":
                    Console.WriteLine("temmuz");
                    break;
                case "8":
                    Console.WriteLine("ağustos");
                    break;
                   
                case "9":
                    Console.WriteLine("eylül");
                    break;
                case "10":
                    Console.WriteLine("ekim");
                    break;
                case "11":
                    Console.WriteLine("kasım");
                    break;
                case "12":
                    Console.WriteLine("aralık");
                    break;
                
                    
            }
                



            
           
               


        }
    }
}
