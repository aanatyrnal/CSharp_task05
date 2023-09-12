Random random = new Random();
double[] array = new double[4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.NextDouble() * (200) - 100; // Генерируем числа в диапазоне [-100, 100)
}

Console.WriteLine("Массив:");
foreach (double num in array)
{
    Console.WriteLine(num);
}

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}

double difference = max - min;

Console.WriteLine($"Разница: {difference}");
