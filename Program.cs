/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/


/* -- решение -- */

Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда exit.");
while (true)
{
    string input = Console.ReadLine();
    if (!input.Equals("exit"))
        Console.WriteLine("{0}->{1}", input, input[1]);
    else
        break;
}


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

/* -- решение -- */

Console.Write("Введи число: ");

int number = Convert.ToInt32(Console.ReadLine());
string numberString = Convert.ToString(number);

if (numberString.Length > 2)
{
    Console.WriteLine("третья цифра -> " + numberString[2]);
}
else
{
    Console.WriteLine("-> третьей цифры нет");
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

/* -- решение -- */

Console.Write("Введи цифру, обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNum)
{
    if (dayNum == 6 || dayNum == 7)
    {
        Console.WriteLine("выходной -> да");
    }
    else if (dayNum < 1 || dayNum > 7)
    {
        Console.WriteLine("в неделе 7 дней)");
    }
    else Console.WriteLine("выходной -> нет");
}

CheckingTheDayOfTheWeek(dayNum);