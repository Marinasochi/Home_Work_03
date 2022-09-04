static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
}

emptyString(6);
string text = new String('*', 40);          // Выводит заданное количество символов,
                                            //  в данном случае 40
Console.WriteLine("    Задача 1");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Напишите программу, которая принимает\r\n на вход пятизначное число и проверяет,\r\n является ли оно палиндромом.");
emptyString(1);
static void Palindrome()
{
    try
    {
        Console.Write("  Введите 5-значное число:  ");
        int digitPalindrome = int.Parse(Console.ReadLine());
        if (digitPalindrome < 100000 & digitPalindrome > 9999 ^ digitPalindrome < -9999 & digitPalindrome>-100000)
            if (digitPalindrome / 10000 == digitPalindrome % 10 && digitPalindrome / 1000 % 10 == digitPalindrome / 10 % 10)
            {

                Console.WriteLine($"Число {digitPalindrome} является палиндромом.");
            }
            else
            {
                Console.WriteLine("Данное число не является полиндромом");
            }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Это число не 5-значное!"); Console.ResetColor();
            Palindrome();
        }
    }

    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Это не число!"); Console.ResetColor();
        Palindrome();
    }
}
Palindrome();
emptyString(6);
Console.WriteLine(text);