// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int sum = 0;
int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
}

PrintArray(array);

for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.Write($"Сумма элементов равна = {sum}\n");


//-----------------------------
void PrintArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
}
