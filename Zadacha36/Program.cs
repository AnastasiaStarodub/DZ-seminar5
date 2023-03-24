// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int numb (string message)
{
    Console.WriteLine(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

void randomArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10,11);
}

int sum(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i+=2)
            result += array[i];
    return result;
}

int arrayLength = numb($"Введите длину массива: ");
int [] array = new int [arrayLength];
randomArray(array);
Console.WriteLine($"Ваш массив: [{string.Join(",", array)}]");
int Summa = sum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Summa}");


