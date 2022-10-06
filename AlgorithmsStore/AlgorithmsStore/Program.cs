using AlgorithmsStore.Algorithms;

public class Program
{
    public static void Main()
    {
        var length = 100;
        var number = 57;
        var myArray = new int[5] { 1, 3, 5, 7, 9 };
        var number2 = 3;

        var errorNumber = 0;

        Console.WriteLine("Искомое число: {0}, количество шагов алгоритма: {1}\n",
                           BinarySearch.Method(length, number).Item1,
                           BinarySearch.Method(length, number).Item2);

        Console.WriteLine("Искомое число: {0}, количество шагов алгоритма: {1}\n",
                           BinarySearch.Method(myArray, number2).Item1,
                           BinarySearch.Method(myArray, number2).Item2);

        /// Проверка на невалидное значение
        Console.Write("Искомое число: {0}, количество шагов алгоритма: {1}",
                           BinarySearch.Method(myArray, errorNumber).Item1,
                           BinarySearch.Method(myArray, errorNumber).Item2);


    }
}
