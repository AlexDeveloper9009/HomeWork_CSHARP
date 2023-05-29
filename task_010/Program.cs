/*Task 010 - Напишите программу , 
которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Clear();
Console.WriteLine("Введите трёхзначное число!");
int num = int.Parse(Console.ReadLine());
int num100 = num / 100 * 100;
int num10 = num % 10;
int sum = (num - (num100 + num10)) / 10;
Console.WriteLine($"{sum}");