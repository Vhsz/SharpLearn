using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Основы программирования
            // 1.Структура программ
            Console.WriteLine("Hello C#");
            // Одни блоки кода могут содержать другие блоки кода
            Console.WriteLine("Блок 1");
            {
                Console.WriteLine("Блок 2");
            }

            // 2. Переменные
            string name = "Tom";
            Console.WriteLine(name);

            name = "Tom2";
            Console.WriteLine(name);
            // Консттанты, они не могут быть изменены, и задаются в начале
            const string name1 = "TomBob";
            Console.WriteLine(name1);

            // 3. Литералы
            // Логические литералы True|False
            Console.WriteLine(true);
            Console.WriteLine(false);
            // Целочисленные литералы 
            // Целые числа
            Console.WriteLine(-11);
            Console.WriteLine(5);
            Console.WriteLine(505);
            // Двоичная форма, с начала идёт символ 0b
            Console.WriteLine(0b11); //3
            Console.WriteLine(0b1011); //11
            Console.WriteLine(0b100001); //33
            // Шестнадцатиричная форма, с начала идёт символ 0x
            Console.WriteLine(0x0A); // 10
            Console.WriteLine(0xFF); // 255
            Console.WriteLine(0xA1); // 161
            //
            //Вещественные литералы
            //
            //Символьные литералы 
            Console.WriteLine('A');
            Console.WriteLine('1');
            Console.WriteLine('-');
            // Управляющие последовательности
            // \t - табуляция
            // \n - перевод строки
            // \\ - слеш
            // Строковые литералы
            Console.WriteLine("Абв");
            Console.WriteLine("Привет, это строка 60");
            // null - ссылка которая указывает ни на какой из объектов

            // 4. Типы данных
            // В c# есть следующие базовые типы данных:
            // bool - хранит True / False 
            bool alive = true;
            bool isDead = false;
            // byte - хранит целое число от 0 до 255, занимает 1 байт
            byte bit1 = 1;
            byte bit2 = 102;
            // sbyte - хранит целое число от -128 до 127, занимает 1 байт
            sbyte sbit1 = -55;
            sbyte sbit2 = 99;
            // short - хранит целое число -32768 до 32767, занимает 2 байта
            short n1 = -1;
            short n2 = 32000;
            // ushort хранит целое число от 0 до 65535, занимает 2 байта
            ushort n3 = 0;
            ushort n4 = 63533;
            // int - целое число от -2147483648 до 2147483647, Занимает 2 байта
            int a = 10;
            int b = 0b101; // 5
            int c = 0xFF; // 255
            // uint - целое число от 0 до 4294967295 и занимает 4 байта;
            uint ua = 10;
            uint ub = 0b101; // 5 
            uint uc = 0xFF; // 255
            // long - хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            long al = -10;
            long bl = 0b101; // 5 
            long cl = 0xFF; // 255
            // ulong - хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            ulong ual = 10;
            ulong ubl = 0b101; // 5
            ulong ucl = 0xFF; // 255
            // float - хранит число с плавающей запятой и занимает 4 байта
            float qq = -101;
            double dq = 101.1;
            // char - хранит сивол в юникоде и занимает 2 байта
            char ca = 'A';
            char cb = '\x5A';
            char cc = '\u0420';
            // string - строка 
            string sa = "Первая строка";
            string sb = "Second string";
            string sc = "Третяя string";
            // object - хранит значение любого типа данных, занимает 4 байта на 32 битной системе - 8 байт на 64 битной системе
            object oa = "a";
            object ob = 3.14;
            object oc = "Hello code";

            string name4 = "Alex";
            int age4 = 22;
            bool isEmployed = true;
            double weight4 = 95.15;

            Console.WriteLine($"Имя {name4}");
            Console.WriteLine($"Возраст {age4}");
            Console.WriteLine($"Работает {isEmployed}");
            Console.WriteLine($"Вес {weight4}");

            // Невяная типизация Var

            var aaa = 20;
            var ccc = "hello";

            //
            // 5. Консольный ввод-вывод
            // Console.WriteLine();
            string hello5 = "Привет мир, это 132 строчка";
            Console.WriteLine(hello5);
            Console.WriteLine("Привет c#");
            Console.WriteLine("Пока c#...");
            Console.WriteLine(24.5);

            // Интерполяция

            string intername = "Edik";
            int interage = 30;
            double interheight = 175.5;
            Console.WriteLine($"Имя: {intername}, Возраст: {interage} лет, Рост: {interheight}см");

            Console.WriteLine("Имя = {0}, Возраст = {2}, Рост = {1}", intername, interheight, interage);

            // Вместо WriteLine, можно использовать Write. он работает точно так же только не добавляет переход на следущую строку 
            // Консольный ввод 
            Console.Write("Введите имя:");
            string namecon = Console.ReadLine();
            Console.Write("Введите возраст:");
            int agecon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите рост:");
            double weightcon = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите размер ЗП:");
            decimal salarycon = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Имя: {namecon}, Возраст: {agecon}, Рост: {weightcon}, Зарплата: {salarycon}");

            //
            //6. Арифметические операции
            //Бинарные арифметические операции
            // +
            int e = 10;
            int ee = e + 12; // 22
            // - 
            int r = 10;
            int rr = r - 5; // 5 
            // *
            int t = 2;
            int tt = t * 2; // 4
            // /
            int y = 10;
            int yy = 10 / 2; // 5
            // % остаток от деления
            double u = 10;
            double uu = u % 4.0; // 2
            // Инкремент ++
            int q1 = 5;
            int qq1 = ++q1; // q1=6 ; qq1 = 6
            Console.WriteLine($"{q1} - {qq1}");
            int q2 = 5;
            int qq2 = q1++; // q2 = 5; qq2 = 6;
            Console.WriteLine($"{q2} - {qq2}");
            // Декремент --
            //
            // 7. Поразрядные операции
            //
            // Логические операции
            // & Логическое умножение 
            int lx1 = 2; // 010
            int ly1 = 5;
            Console.WriteLine(lx1 & ly1);

            int lx2 = 4;
            int ly2 = 5;
            Console.WriteLine(lx2&ly2);
            // | логическое сложение
            int lsx1 = 2;
            int lsy1 = 5;
            Console.WriteLine(lsx1 | lsy1);
            int lsx2 = 4;
            int lsy2 = 5;
            Console.WriteLine(lsx2 | lsy2);
            // ^ логическое исключающее ИЛИ
            int x1y = 45;
            int key1y = 102;
            int encrypt1 = x1y ^ key1y;
            Console.WriteLine($"Зашифрованное число: {encrypt1}");

            int decrypt = encrypt1 ^ key1y;
            Console.WriteLine($"Расшифрованное число: {decrypt}");
            // ~ логическое отрицание или инверсия 
            int invx1 = 12;
            Console.WriteLine(~invx1);
            // Операция сдвига 
            int sda = 16;
            int sdb = 2;
            int sdc = sda << sdb;
            Console.WriteLine($"Зашифрованное число {sdc}");

            int sdd = sda >> sdc;
            Console.WriteLine($"Расшифрованное число: {sdd}");
            //
            // 8. Операции присваивания
            //
            int number8 = 23;
            int a8, b8, c8;
            a8 = b8 = c8 = 34;
            Console.WriteLine($"Данные a8 = {a8}, b8 = {b8}, c8 = {c8}");

            int aa8 = 10;
            aa8 += 10; // 20
            aa8 -= 4; //6
            aa8 *= 2; // 32
            aa8 /= 8; //4
            aa8 <<= 4; //64
            aa8 >>= 2; //16
            //
            // 9. Преобразование базовых типов данных
            //
            byte a9 = 4;
            int b9 = a8 + 70;
            ///////// Важно!  При приобразовании типов, (тип данных) (сами данные)
            byte aa9 = 4;
            byte ab9 = (byte)(aa9 + 70);
            // Сужиющие и расширающие преобразования
            //
            // 10. Условные выражения
            // Операция сравнения
            // == сравнивает 2 операнда на равенство 
            int a10 = 10;
            int b10 = 4;
            bool c10 = a10 == b10;
            Console.WriteLine($"10 блок - 248 строка {c10}");
            // != сравнивает два операнда и возвращает True. если операнды не равны, false если они равны
            int aa10 = 10;
            int bb10 = 4;
            bool cc10 = aa10 != bb10;
            bool dd10 = aa10 != 10;
            Console.WriteLine(dd10);
            Console.WriteLine(cc10);
            /// < операция меньше чем
            /// > операция больше чем
            /// <= меньше или равно
            /// => больше или равно
            // Логические операции
            /// | операция логического сложения или логическое ИЛИ, возвращает true, если хотябы один из операндов возвращает true
            /// & Операция логического умножения или логическое И, возвращает true, если оба операнда true
            /// || Операция логического сложения, возвращает true, если хоть один из операндов возвращает true
            /// && Операция логического умножения, возвращает true, если оба операнда одновременно true
            /// ! Операция логического отрицания, если true = false, false = true;
            /// ^ Операция исключающего ИЛИ, возвращает true, если либо первый либо второй операнд (не одновременно) равны true, иначе возвращает false
            //
            
























        }
    }
}
