using System;

namespace Rab_5_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов. Заполнить массив числами,
            //вводимыми с клавиатуры, определить среднее арифметическое элементов.


            const int n = 7;

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {

                Console.Write($"Введите элемент массива {i}\t");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив");


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое элементов массива");
            float  sredn = 0;
            for (int i = 0; i < array.Length; i++)
                sredn += array[i];
            float sa =sredn / array.Length;
          
            Console.WriteLine();
            Console.Write("{0:f3} ",sa) ;

            Console.ReadKey();

        }
    }
}
