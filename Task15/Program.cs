// // Напишите программу, которая принимает на вход цифру,
// // обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Day of the week ");
int weekNumber = Convert.ToInt32(Console.ReadLine());

void WeekDayTest(int number)
{
    if (weekNumber == 6 || weekNumber == 7)
    {
        Console.WriteLine("weekend!");
    }
    else if (weekNumber < 1 || weekNumber > 7)
    {
        Console.WriteLine("r u ok?");
    }
    else Console.WriteLine("Today is not your day!");
}
WeekDayTest(weekNumber);
