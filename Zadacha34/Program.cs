// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void randomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

int count(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result += +1;
    }
    return result;
}

int arrayLength = numb($"Введите длину массива: ");
int[] array = new int[arrayLength];
randomArray(array);
Console.WriteLine($"Ваш массив: [{string.Join(",", array)}]");
int evenNumber = count(array);
Console.WriteLine($"Количество четных чисел в массиве равно {evenNumber}");









