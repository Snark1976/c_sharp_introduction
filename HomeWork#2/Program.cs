bool flag = true;
while  (flag)
{
    Console.WriteLine("Введите номер задачи (10, 13 или 15) для проверки или все, что угодно, для выхода");
    switch (Console.ReadLine())
    {
        case "10": 
            Task10(); 
            break;
        case "13":
            Task13();
            break;
        case "15":
            Task15();
            break;
        default: 
            flag = false;
            break;
    };
}

static void Task10()
{
    Console.WriteLine("\nВведите трехзначное число: ");
    Console.WriteLine($"Вторая цифра равна {Console.ReadLine()[1]}\n\n");
}

static void Task13()
{
    Console.WriteLine("\nВведите число: ");
    string? number = Console.ReadLine();
    Console.WriteLine(number?.Length > 2 ? $"Третья цифра равна {number[2]}\n\n" : "Третьей цифры нет\n\n");
}

static void Task15()
{
    Console.WriteLine("\nВведите день недели (1 - 7): ");
    Console.WriteLine((new string[] {"6", "7"}).Contains(Console.ReadLine()) ? "Выходной день\n\n" : "Будний день\n\n");
}
