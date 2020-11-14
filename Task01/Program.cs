using System;

/*
 * Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.​
 *
 * В основной программе объявить и инициализировать массив
 * (данные вводятся с клавиатуры: сначала количество элементов, далее сам массив поэлементно с новой строки);
 * Из последней введенной строки получить от пользователя число,
 * заменить им все вхождения максимального элемента в массив.
 * 
 * Исходный и изменённый массивы вывести на экран.​
 *
 * Дополнительные указания смотрите непосредственно в коде
 *
 * Пример входных данных:
 * 5
 * 4
 * 7
 * 3
 * 2
 * 4
 * 10
 *
 * Пример выходных данных:
 * 4 7 3 2 4
 * 4 10 3 2 4
 */

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask01();
        }

        public static void RunTask01()
        {
            int numOfItems = int.Parse(Console.ReadLine());

            int[] array;
            // TODO: считайте массив
            array = new int[numOfItems];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int newValue; // значение, которым нужно заменить все максимальные элементы
                          // TODO: считайте новое значение
            newValue = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", array) + " ");
            ReplaceMaxElem(ref array, newValue);
            Console.WriteLine(string.Join(" ", array));
        }

        static void ReplaceMaxElem(ref int[] arr, int val)
        {
            int max = int.MinValue;
            foreach (var el in arr)
            {
                if (el > max)
                    max = el;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == max)
                    arr[i] = val;
            }
        }
    }
}