Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");

void PrintNum(int start)
{
  if(start>0)
  {
  Console.Write("{0:D} ", start);
  PrintNum(start-1);
  } 
}

Console.Write("Введите число N:");
PrintNum(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine();