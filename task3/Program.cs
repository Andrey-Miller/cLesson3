// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNumber(string str)
{
    int number;
    string text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number) && number > 0)
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, повторите ввод");
    }
    return number;
}

int num = InputNumber("Введи число N: ");
Console.Write($"Кубы от 1 до {num}: ");
for (int i = 1; i <= num; i++)
{
    Console.Write($"{(int) Math.Pow(i, 3)} ");
}