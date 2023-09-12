﻿Random random = new Random();

int[] array = new int[4]; 

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
}

Console.WriteLine("Массив:");
foreach (int num in array)
{
    Console.WriteLine(num);
}

int evenCount = 0;
foreach (int num in array)
{
    if (num % 2 == 0)
    {
        evenCount++;
    }
}

Console.WriteLine($"Сумма: {evenCount}");
