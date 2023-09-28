using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //11.Конструкция if..else и тернарная операция
            // if 
            int num11 = 6;
            int num12 = 4;
            int num13 = 8;
            if (num11 > num12)
            {
                Console.WriteLine($"Число {num11}, больше чем {num12}");
            }

            if (num11 > num12) Console.WriteLine($"Второй способ, число {num11}, больше чем {num12}");

            if (num11>num12 && num11 == 6)
            {
                Console.WriteLine("Первое число больше второго и = 6");
            }


            if (num11 < num12)
            {
                Console.WriteLine("Чет тут не так");
            }
            else
            {
                Console.WriteLine("Вроде правильно");
            }

            if (num11 < num12)
            {
                Console.WriteLine("Чет не то");
            }
            else if (num13 > num11)
            {
                Console.WriteLine("Сюдаа");
            }
            else
            {
                Console.WriteLine("Код говна");
            }


           
            }
        }
    }
}
