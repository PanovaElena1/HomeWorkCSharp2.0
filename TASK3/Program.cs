//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите число от 1 до 7: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
if (numb >= 6)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}

