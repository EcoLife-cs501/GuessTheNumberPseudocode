﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberFULL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Назначение: программа угадывает число от 1 до 99, которое загадал игрок.
            // Программа предлагает игроку число, и игрок вводит одну из команд
            // yes (это число), more (число больше), less (число меньше).
            // Она делает это с помощью двойоного сечения

            // Включим русский язык:
            Console.OutputEncoding = Encoding.UTF8;
            // Объявим переменные. Нам понадобится целое для нижнего значения,
            int lowerBound = 1;
            // целое для верхнего значения
            int upperBound = 99;
            // целое для хранения границы, которые мы сейчас проверяем
            int currentNumber;
            // строка для хранения ввода игрока
            string userInput;
            // логическая переменная, которая хранит true пока цифра не найдена
            bool notFound = true;

            // Выведем инструкцию игроку:
            // "Загадайте число от 1 до 99, а я его угадаю!"
            Console.WriteLine("Загадайте число от 1 до 99, а я его угадаю!");
            // "Я буду предлагать числа, а Вы отвечайте yes (это число),
            Console.WriteLine("Я буду предлагать числа, а Вы отвечайте yes (это число),");
            // "more (Ваше число больше) или less (Ваше число меньше)"
            Console.WriteLine("more (Ваше число больше) или less (Ваше число меньше)");


            // Итак, до тех пор пока номер не найден... (пока "цифра не найдена" = правда - цикл выполняется)
            while (notFound)
            {
                // разделим пространство вариантов на 2 части и возьмем цифру, которая посередине...
                currentNumber = (lowerBound + upperBound) / 2;
                // покажем ее пользователю...
                Console.WriteLine("Это цифра " + currentNumber + "?");
                // и спросим его ввод:
                userInput = Console.ReadLine();
                // теперь нам надо обработать все случаи (cases) его ввода...
                
                {

                    // если он ввел yes - то мы нашли цифру, 
                    
                        // напишем пользователю "Ура, цифра была [цифра]! Спасибо за игру!"
                        
                        // и устанавливаем переменную "цифра не найдена" в false (чтоб выйти из цикла)
                        
                         // все остальные случаи (cases) не проверяем - нет смысла :)

                    // если он ввел more (его цифра больше), то нам надо искать в верхней половине пространства вариантов, и...
                    
                        // мы устанавливаем наше число нижней границей пространства вариантов и...
                        
                        // начинаем поиск по новой, запустив цикл по новой!
                        

                    // если он ввел  less (его цифра меньше), то нам надо искать в нижней половине пространства вариантов, и...
                    
                        // мы устанавливаем наше число верхней границей пространства вариантов и...
                        
                        // начинаем поиск по новой, запустив цикл по новой!
                        

                    // если он ввел что-то другое, то напомним пользователю допустимые команды. Выведем сообщение...
                    
                        // "Не понимаю ввод. Допустимый ввод yes, less, more."...
                        
                        // и запустим цикл по новой!
                        
                     

                }


            }
            // Это самый самый конец программы. Мы попадаем сюда выйдя из цикла "Пока число не найдено..."
            // остановим программу, попросив ее подождать нажатия любой клавиши, и насладимся моментом! :)

            // Поздравляю, Вы только что написали первую серьезную программу на С#!!! :)

        }
    }
}
