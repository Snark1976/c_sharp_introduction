bool flag = true;
do
{
    Console.WriteLine("Введите номер задачи (2, 4, 6 или 8) для проверки или все, что угодно, для выхода");
    switch (Console.ReadLine())
    {
        case "2": 
            Task2(); 
            break;
        case "4":
            Task4();
            break;
        case "6":
            Task6();
            break;
        case "8":
            Task8();
            break;
        default: 
            flag = false;
            break;
    };

}
while  (flag);

static void Task2()
{
    Console.WriteLine("\nВведите первое число");
    double num1 = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите второе число");
    double num2 = double.Parse(Console.ReadLine()!);
    Console.WriteLine($"Наибольшее число равно {Math.Max(num1, num2)}\n\n");
}

static void Task4()
{
    Console.WriteLine("\nВведите первое число");
    double max = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите второе число");
    max = Math.Max(double.Parse(Console.ReadLine()!), max);
    Console.WriteLine("Введите третье число");
    max = Math.Max(double.Parse(Console.ReadLine()!), max);
    Console.WriteLine($"Наибольшее число равно {max}\n\n");
}

static void Task6()
{
    Console.WriteLine("\nВведите число");
    int num = int.Parse(Console.ReadLine()!);
    string answer = num % 2 == 0 ? "Это четное число" : "Это нечетное число";
    Console.WriteLine(answer + "\n\n");
}

static void Task8()
{
    Console.WriteLine("\nВведите число");
    int num = int.Parse(Console.ReadLine()!);
    List<int> evenNumbers = new();
    for (int i = 2; i <= num; i += 2)
        evenNumbers.Add(i);
    Console.WriteLine(string.Join(", ", evenNumbers) + "\n\n");
}