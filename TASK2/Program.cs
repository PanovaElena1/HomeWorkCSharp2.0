// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число: ");
int numb = Convert.ToInt32 (Console.ReadLine ());
if (numb>99)
{
    int MakeArray = numb;
    int digitIndex = 2;
    int digit = numb.ToString()[digitIndex] - '0';
    System.Console.WriteLine(digit);
}
else 
{
    System.Console.WriteLine("Третьей цифры нет");
    
}
