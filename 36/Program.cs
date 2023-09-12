 Random random = new Random();
int[] array = new int[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-100, 100);
}

Console.WriteLine("Массив:");
foreach (int num in array)
{
    Console.WriteLine(num);
}

int oddPositionSum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        oddPositionSum += array[i];
    }
}

Console.WriteLine($"Сумма: {oddPositionSum}");