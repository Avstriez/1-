/*Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8    */

void Fibonacci(int number)
{
    int a = 0; Console.Write($"{a}");
    int b = 1;
    for (int i = 0; i < number; i++)
    {
        (a, b) = (b, a + b);
        Console.Write(string.Format($", {a}"));
    }
    Console.WriteLine(); 
}

int GetNumber(string text)
{
    Console.WriteLine(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int num = GetNumber("Введите число: ");
Fibonacci(num-1);