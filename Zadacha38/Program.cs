// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int numb(string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void randomArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11) + new Random().NextDouble();
}

void PrintArray(double[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]:F2}  ");
    Console.WriteLine();
}

double find (double [] array)
{
    double max = 0;
    double min = 0;
    double result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
        result = max - min;
    }
    return result;
}

int arrayLength = numb($"Введите длину массива: ");
double[] array = new double[arrayLength];
randomArray(array);
PrintArray(array);
double difference = find(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {difference:F2}");




