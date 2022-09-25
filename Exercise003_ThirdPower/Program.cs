static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
 {
    int a = 0;
    while (a < howmanyString)
    {
        Console.WriteLine();
        a++;
    }
 }

 int NumberInput(string message) //позволяет ввести именно число с консоли, возвращая 
 {                               //пользователя к вводу, если число не распознано, до 
    int index = 0;               //тех пор пока ввод не будет удачен
    int number = 0;
    while (index < 1)
    {
        Console.Write("Введите число:  ");
        string text = Console.ReadLine();
            if (int.TryParse(text, out number))
                { Console.WriteLine($"Вы ввели число: {number} . "); index++; }
            else
                { Console.WriteLine("Не удалось распознать число, попробуйте еще раз."); }
    }
    return number;
 }

void PowerNumber(int numbers, int degree) // возводит принимаемое целое число в принимаемую степень
 {  
    Console.WriteLine($"Числа от 1 до {numbers} в  {degree} степени");                                       
    for(int i = 1; i < numbers + 1; i++)  
       {
          int res = i;
          for(int j = 1; j < degree; j++)
            { res *= i; }
          Console.WriteLine($"   {i}\t \t{res}");
       }
 }

emptyString(6);
string text = new String('*', 40);  // Выводит заданное количество символов, в данном случае 40
Console.WriteLine(text);
Console.WriteLine("    Задача 3");
Console.WriteLine(text);
emptyString(1);
Console.WriteLine("  Напишите программу, которая принимает на вход \n число (N) и выдаёт таблицу кубов чисел от 1 до N.");
emptyString(1);
int n = NumberInput("Введите число ");
PowerNumber(n, 3);
Console.WriteLine(text);
emptyString(2);
