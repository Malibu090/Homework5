// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const int leftRange = 0;
const int rightRange = 100;
int size = SizeArray("Введите длину массива ");
double[] array = new double[size];
Random rand = new Random();

int SizeArray(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return arr;
}

void FindMinMax(double[] array, out double Min, out double Max, out double DiffMinMax)
{
    Min = array[0];
    Max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (Min > array[i])
        {
            Min = array[i];
        }
        if (Max < array[i])
        {
            Max = array[i];
        }

    }
    DiffMinMax = Max - Min;
}

array = FillArrayWithRandomNumbers(size, leftRange, rightRange);
System.Console.WriteLine('[' + string.Join("; ", array) + ']');
FindMinMax(array, out double Min, out double Max, out double DiffMinMax);
System.Console.WriteLine($"Разница между {Max} и {Min} равна {DiffMinMax}");
