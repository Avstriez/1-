//Задача 25: Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int GetNature(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}


int GetNumber(string text) //создаем первый метод(функцию)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numberA = GetNumber("ВВедите первое число: ");
int numberB = GetNumber("ВВедите второе число: ");

int result = GetNature(numberA, numberB);
Console.WriteLine(result);