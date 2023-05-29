/*
Задача #13
Напишите программу, которая выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
//я это решение честно откопал в интернете ,
// были и другие варианты но тут реализация огонь
// Console.WriteLine("Введите число : ");

// int number = Convert.ToInt32(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length > 2)
// {
//     Console.WriteLine("третья цифра -> " + numberText[2]);
// }
// else
// {
//     Console.WriteLine("-> третьей цифры нет");
// }
//UPD: Я подглядел в эталонное решение и вспомнил что мы же теперь используем методы xD
//Пытался разобраться в итоге запутался
int Msg(string message)
{
    Console.WriteLine(message);
    string num1 = Console.ReadLine();
    int result = Convert.ToInt32(num1);
    return result;
}
int TaskAndQue(int number)
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}
bool FalseNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;

    }
    return true;
}
int number = Msg("Введите число >: ");
if (FalseNumber(number))
{
    Console.WriteLine(TaskAndQue(number));
}