// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double min, max;
double[] array = new double[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10) / 10.0;
}

PrintArray(array);

min = array[0];
max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    else 
    {
        if (array[i] < min) min = array[i];
    }
}

Console.Write($"max = {max}        min = {min}\n");
Console.Write($"Разница между max и min = {Math.Round((max - min),2)}\n");


//-----------------------------
void PrintArray(double[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}