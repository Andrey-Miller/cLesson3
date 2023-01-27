// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

string InputNumber(string str)
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
    return text;
}

bool Palindrome(string str)
{
    bool isPalindrome = true;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome;
}

string num = InputNumber("Введите число: ");
if (Palindrome(num))
{
    System.Console.WriteLine($"Число {num} - палиндром");
}
else
{
    System.Console.WriteLine($"Число {num} - не палиндром");
}
