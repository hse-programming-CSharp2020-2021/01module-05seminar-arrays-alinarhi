using System;

/*
 * Пользователем с клавиатуры вводятся целые числа N > 1, A и D.
 * В программе сформировать и вывести на экран целочисленный массив из N элементов.
 * Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D.
 * Формирование массива организовать при помощи метода.​
 *
 * Пример входных данных:
 * 5
 * 3
 * 4
 *
 * Пример выходных данных:
 * 3 7 11 15 19
 */

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTask04();
        }

        public static void RunTask04()
        {
            int N = int.Parse(Console.ReadLine());
            double A, D;
            // TODO: считайте необходимые значения A и D
            A = double.Parse(Console.ReadLine());
            D = double.Parse(Console.ReadLine());
            // TODO: инициализируйте массив и передайте его в соответствующий метод вместе с необходимыми значениями 
            double[] arr = new double[N];
            FillArray(arr, A, D);
            // TODO: выведите массив на экран
            Console.WriteLine(string.Join(" ", arr));
        }
        
        static void FillArray(double[] arr, double a, double d)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = a + i * d;
            }
        }
    }
}