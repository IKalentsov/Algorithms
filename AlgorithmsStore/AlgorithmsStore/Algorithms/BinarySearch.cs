using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsStore.Algorithms
{
    /// <summary>
    /// 1. Задаем минимальное и максимальное нумерации ячеек массива
    /// 2. Среднее значение
    /// 3. Если среднее значение равно искомому числу возвращаем число
    /// 4. Если среднее значение array[mid] меньше искомого, то минимальное 
    ///    значение low равно среднему array[mid].
    /// 5. Если среднее значение array[mid] больше искомого, то максимальное 
    ///    значение high равно среднему array[mid].
    /// </summary>
    public static class BinarySearch
    {
        public static (int, int) Method(int lenghtArr, int number)
        {
            var array = GenerateArray(lenghtArr);
            
            var low = 0; // 1.
            var high = array.Length - 1; // 1.

            var mid = (low + high) / 2; // 2.

            var incr = 1;
            while (low < high) // 3.
            {
                mid = (low + high) / 2;

                if (array[mid] == number) return (array[mid], incr);

                if (array[mid] < number) // 4.
                {
                    low = mid;
                    incr++;
                }
                else // 5.
                {
                    high = mid;
                    incr++;
                }
            }

            throw new ArgumentException($"Числа number = {number} нет в искомом массиве");
        }

        public static (int, int) Method(int[] array, int number)
        {
            if (number < 0) throw new ArgumentException($"Число number = {number} отрицательно");

            var low = 0; // 1.
            var high = array.Length - 1; // 1.

            var mid = (low + high) / 2; // 2.

            var incr = 1;
            while (low < high) // 3.
            {
                mid = (low + high) / 2;

                if (array[mid] == number) return (array[mid], incr);

                if (array[mid] < number) // 4.
                {
                    low = mid;
                    incr++;
                }
                else // 5.
                {
                    high = mid;
                    incr++;
                }
            }

            throw new ArgumentException($"Числа number = {number} нет в искомом массиве");
        }

        private static int[] GenerateArray(int lenghtArr)
        {
            var arr = new int[lenghtArr];

            for (int i = 1; i <= lenghtArr; i++)
            {
                arr[i - 1] = i;
            }

            return arr;
        }
    }
}
