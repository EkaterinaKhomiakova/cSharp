// Task 1 Напишите программу, которая на вход принимает число и выдает его квадрат(число умноженное на самосебя)
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49
//Console.Write("Enter the integer: ");
//int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n * n);

//Task2 Напишите программу, которая на вход принимает два числа и
// проверяет является ли первое число квадратом второго
// Например:
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

//Console.Write("Enter the integer: ");
//int n1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter the integer: ");
//int n2 = Convert.ToInt32(Console.ReadLine());

//if (n1 == n2 * n2)
//{
// Console.WriteLine("yes");
//}
//else
//Console.WriteLine("no");


//Task 3. Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру
// 3 -> среда
// 5 -> пятница
// Console.Clear();
//Console.Write("Enter the number of the day of the week ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());
//if (dayNumber == 1)
//  Console.WriteLine("Monday");
//else if (dayNumber == 2)
// Console.WriteLine("Tuseday");
//else if (dayNumber == 3)
//  Console.WriteLine("Wensday");
//else if (dayNumber == 4)
// Console.WriteLine("Thursday");
//else if (dayNumber == 5)
// Console.WriteLine("Friday");
//else if (dayNumber == 6)
//Console.WriteLine("Saturday");
//else if (dayNumber == 7)
// Console.WriteLine("Sunday");
//else
//Console.WriteLine("Вы не ввели число от 1 до 7");

//Task 4. Напишите программу, которая на вход принимает одно число (N)
// а на выходе показывает все целые числа в промежутке от -N до N 
// 4 -> "-4,-3,-2,-1,0,1,2,3,4"
// 2 -> "-2, -1, 0, 1, 2"

// Console.Write("Enter the number N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i = -N; i <= N; i++)
// {
// Console.Write($"{i} ");
// }

// Task 5.Напишите программу, которая на вход принимает трехзначное число (N)
// а на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter the integer: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Последняя цифра: {N % 10}");
