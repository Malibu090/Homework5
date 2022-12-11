// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int leftRange = 100;
const int rightRange = 999;
int size = SizeArray("Введите длину массива ");
int[] array = new int[size];
Random rand = new Random();

int SizeArray(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void CountEven(int[] array, out int count)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    }
}

array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
CountEven(array, out int count);
System.Console.WriteLine("Количество четных чисел = " + count);
