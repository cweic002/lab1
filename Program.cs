using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1
{
    class Program
    {
        private static int InputInt()  //Функция возвращает вещественное число
        {
            int number;
            string value;
            do
            {
                value = Console.ReadLine();          //Ожидаем ввода данных
                if (int.TryParse(value, out number)) // Проверка правильности вещественности чисел
                    return number;                   //Возвращаем число
                Console.WriteLine(" Данные не являются вещественным числом! ");  //Вызов сообщения
                Console.Write("Введите число снова: ");                          //Вызов сообщения
            }
            while (true); // Замкнутый цикл
        }
        static void Main()
        {
            int a, b, c, d, x1, x2;
            Console.WriteLine("Введите число а");  //Вызов сообщения
            a = InputInt();                        //Вызов функции
            Console.WriteLine("Введите число b");  //Вызов сообщения
            b = InputInt();                        //Вызов функции
            Console.WriteLine("Введите число c");  //Вызов сообщения
            c = InputInt();                        //Вызов функции
            d = b * b - 4 * a * c;                 //Математические операции
            if (d == 0)                            //Сравнение D и 0
            {
                x1 = (-b) / (2 * a);               //Математические операции11
                Console.WriteLine("Ответ {0}", x1);//Вызов сообщения
            }
            else if (d > 0)  //Сравнение D и 0
            {
                x1 = (-b + (int)Math.Sqrt(d)) / (2 * a);//Математические операции
                Console.Write("Ответ {0}", x1);         //Вызов сообщения
                x2 = (-b - (int)Math.Sqrt(d)) / (2 * a);//Математические операции
                Console.WriteLine(",{0}", x2);          //Вызов сообщения
            }
            else   // иначе
            {
               Console.WriteLine("Нет корней");        //Вызов сообщения
               Main();                                 //Вызов функции в даном случае перезапуск
            }
            Console.ReadLine();                        //Ожидания ввода 
        }
    }
}

