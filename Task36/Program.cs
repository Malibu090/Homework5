// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int leftRange = -100;
const int rightRange = 100;
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

void SumUneven(int[] array, out int result)
{
    result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
}

array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
SumUneven(array, out int result);
System.Console.WriteLine("Сумма нечетных элементов = " + result);
