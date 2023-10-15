internal class Program
{
    private static void Main(string[] args)
    {
        bool flag;
        Random rand = new();
        do
        {
            Console.Write("Введите номер задачи (64, 66 или 68) для проверки или все, что угодно, для выхода: ");
            flag = Console.ReadLine() switch
            {
                "64" => Task64(),
                "66" => Task66(),
                "68" => Task68(),
                _ => false
            };
        }
        while (flag);
    }

    static bool Task64()
    {
        Console.Write("Введите два числа (разделитель пробел): ");
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        string result = string.Join(", ", GetNatureNumbers(numbers[0], numbers[1]));
        Console.WriteLine($"Между введенными числами находятся следующие натуральные числа: {result}");
        return true;
    }

    static bool Task66()
    {
        Console.Write("Введите два числа (разделитель пробел): ");
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        int result = GetNatureNumbers(numbers[0], numbers[1]).Sum();
        Console.WriteLine($"Сумма чисел между введенными числами: {result}");
        return true;
    }

    static bool Task68()
    {
        Console.Write("Введите два числа (разделитель пробел): ");
        int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        int akkerman = Akkerman(numbers[0], numbers[1]);
        Console.WriteLine($"Значение функции Аккермана для введенных чисел: {akkerman}");
        return true;
    }

    static List<int> GetNatureNumbers(int first, int last)
    {
        List<int> result = new();
        for (int i = Math.Max(first, 1); i <= last; i++)
            result.Add(i);
        return result;
    } 

    static int Akkerman(int n, int m)
    {
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
            return Akkerman(n - 1, 1);
        else
            return Akkerman(n - 1, Akkerman(n, m - 1));
    }
}