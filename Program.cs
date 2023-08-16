// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());

if(number > 7 || number < 1)   
{
    Console.WriteLine("День недели не существует. Введите число от 1 до 7");
    return;
}     
if (number > 5)
{
Console.WriteLine("Да, выходной."); 
   return;
}
if(number <= 5)
{
 Console.WriteLine("Нет, работай.");
    return;
}

    
   
   