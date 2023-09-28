using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program1
    {
        static void Main1 (string[] args)
        {
            //Теперь несколько усложним ситуацию в создаваемой программе. Пусть пользователь имеет возможность ввести одно число, причем:
            //— когда значение больше пяти и одновременно с этим меньше десяти, выводится один текст с соответствующим сообщением;
            //—  когда значение не попадает в указанный диапазон, программа его не узнает, выводя другой текст с соответствующим сообщением. Таким образом, алгоритм решения будет несколько отличаться:
            Console.Write("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum;

            if (a == b)
            {
                Console.WriteLine("Введёные числа равны");
            }
            else if (a < b)
            {
                sum = b - a;
                Console.WriteLine($"Разница между числами составляет: {sum}");
            }
            else
            {
                sum = a - b;
                Console.WriteLine($"Разница между числами составляет: {sum}");
            }
        }
    }
}
