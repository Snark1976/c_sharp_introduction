bool flag;
do
{
    Console.Write("Введите номер задачи (25, 27 или 29) для проверки или все, что угодно, для выхода: ");
    flag = Console.ReadLine() switch
    {
        "25" => Task25(),
        "27" => Task27(),
        "29" => Task29(),
        _ => false
    };
}
while (flag);

static bool Task25()
{
    Console.Write("Введите пару чисел (разделитель пробел): ");
    // ! добавляю для подавления подчеркиваний nullable ReadLine(). Просто очень не люблю, когда есть в коде любые предупреждения.
    int[] numbers = Console.ReadLine()!.Split(' ').Select(x => int.Parse(x)).ToArray();
    int pow = numbers[0];
    for (int i = 1; i < numbers[1]; i++)
        pow *= numbers[0];
    Console.WriteLine($"{numbers[0]} ^ {numbers[1]} = {pow}");
    return true;
}

static bool Task27()
{
    Console.Write("Введите число: ");
    Console.WriteLine($"Сумма цифр равна: {Console.ReadLine()!.Sum(x => int.Parse(x.ToString()))}");
    return true;
}

static bool Task29()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()!);
    int[] array = new int[num];
    Random rand = new();
    for (int i = 1; i < num; i++)
        array[i] = rand.Next(10);
    Console.WriteLine($"[{string.Join(", ", array)}]");
    return true;
}
