﻿using System;

/*
 * Пользователем с клавиатуры вводится целое число N > 0
 * В программе сформировать и вывести на экран целочисленный массив из N элементов
 * Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2^(N-1)).
 * Заполнение массива степенями числа 2 организовать при помощи метода.
 *
 * Пример входных данных:
 * 4
 *
 * Пример выходных данных:
 * 1 2 4 8
 */

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask02();
        }

        public static void RunTask02()
        {
            int N = int.Parse(Console.ReadLine());
            double[] arr = new double[N];

            FillArray(arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void FillArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Pow(2, i);
            }
        }
       
    }
}