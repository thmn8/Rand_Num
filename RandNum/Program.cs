﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandNum
{
    class Program
    {
        static void Rules()
        {
            //Вывод правил игры
            Console.WriteLine("Правила игры: \nУгадай число, за определенное число попыток. \n\nНастроим условия игры: ");
        }
        static int GenerationRandValue(int interval)
        {
            Random rand = new Random();
            int rndValue = 1 + rand.Next(interval); //генерируем случайно число и записываем его в переменную
            return rndValue; //возвращаем рандомное значени
        }

        static String Game(int attemp, int rndValue, int interval)
        {
            int numAttemp = 0; //хранение количества попыток
            while (attemp > 0)
            {
                numAttemp++; //счетчик попыток (с какой угадал)
                attemp--; //счетчик попыток (сколько осталось)
                Console.WriteLine("Попытка " + numAttemp + ". Введите число: ");
                int entNum = Convert.ToInt32(Console.ReadLine()); //запись числа, которое ввел пользователь

                if (entNum == 0 || entNum > interval || entNum < 0)
                {
                    Console.WriteLine("Будь внимтельнее! От 1 до " + interval + ".");
                }
                if (entNum == rndValue)
                {
                    Console.WriteLine("Молодец! Ты угадал с " + numAttemp + " попыткию");
                    break;
                }
                if (attemp == 0)
                {
                    Console.WriteLine("Не угадал, это число " + rndValue + ".");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Угадай число"; //заголовок окна консоли
            Rules(); //вывод правил

            Console.WriteLine("Выберите промежуток чисел от 1 до ");
            int interval = Convert.ToInt32(Console.ReadLine()); //запись числа, которое будет промежутком в переменную

            Console.WriteLine("Введите количество попыток: ");
            int attemp = Convert.ToInt32(Console.ReadLine()); //запись числа, которое будет количеством попыток в переменную

            int rndValue = GenerationRandValue(interval); //записываем в перменную rndValue рандомное число, полученное из метода GenerationRandValue

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}