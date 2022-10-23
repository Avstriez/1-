// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 * num1;
if(result == num2) Console.WriteLine($"Первое число {num1} является квадратом второго {num2}");
else Console.WriteLine("не является квадратом");
