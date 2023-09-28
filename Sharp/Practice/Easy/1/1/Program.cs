using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Необходимо написать консольную программу,
            //где пользователь будет вводить с клавиатуры 2 числа.
            //Числа будут сравниваться с последующим выводом в консоль результата этого сравнения
            //(равны ли значения, а если нет, то какое число больше/меньше).

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
