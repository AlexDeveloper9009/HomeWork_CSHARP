﻿// Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
int number = System.Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной! =-)");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Работаем =-(!");
}
