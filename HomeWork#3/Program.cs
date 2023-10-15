bool flag;
do
{
    Console.Write("Введите номер задачи (19, 21 или 23) для проверки или все, что угодно, для выхода: ");
    flag = Console.ReadLine() switch
    {
        "19" => Task19(),
        "21" => Task21(),
        "23" => Task23(),
        _ => false
    };
}
while (flag);

static bool Task19()
{
    Console.Write("Введите любое число: ");
    string number = Console.ReadLine()!;
    string answer = number == new string(number.Reverse().ToArray()) ? "Это палиндром" : "Это не палиндром";
    Console.WriteLine(answer);
    return true;
}

static bool Task21()
{
    Console.Write("\nВведите координаты первой точки (разделитель - пробел): ");
    double[] point1 = Console.ReadLine()!.Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.Write("\nВведите координаты второй точки (разделитель - пробел): ");
    double[] point2 = Console.ReadLine()!.Split(' ').Select( x => Convert.ToDouble(x)).ToArray();
    Console.WriteLine($"D = {Math.Sqrt(point1.Zip(point2, (first, second) => Math.Pow(first - second, 2)).Sum())}");
    return true;
}

static bool Task23()
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine()!);
    for (int i = 1; i <= num; i++)
        Console.WriteLine($"{i * i * i} ");
    return true;
}
