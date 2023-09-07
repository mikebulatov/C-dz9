Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");


int SumNum(int N,int M)
{
  if(N<M)
  {
    return N+SumNum(N+1,M);
  
  } 
  if(N>M)
  {
    return M+SumNum(N,M+1);
  
  }
  return M;
}

Console.Write("Введите натуральное число N:");
int N=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число M:");
int M=Convert.ToInt32(Console.ReadLine());
if (N>0 & M>0){
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {SumNum(N,M)}");  
}
else{
  Console.WriteLine("Одно или оба введеных числа не натральные");
}
