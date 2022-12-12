// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int count = 0;
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
}

PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) 
    {
        count = count + 1;
    }
}
Console.Write($"Количество четных чисел в массиве = {count}\n");


//-----------------------------
void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}