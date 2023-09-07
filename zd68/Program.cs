Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");


int Akkerman(int m,int n)
{
  if(m>0)
  {
   if(n>0) return Akkerman(m-1,Akkerman(m,n-1));
   else return Akkerman(m-1,1);
  }
  else return n+1;
  
}

Console.Write("Введите неотрицательное число m:");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n:");
int n=Convert.ToInt32(Console.ReadLine());
if (m>=0 & n>=0){
Console.WriteLine($"Значение функции Аккермана для чисел {m} и {n} равна {Akkerman(m,n)}");  
}
else{
  Console.WriteLine("Одно или оба введеных числа отрицательные");
}
