//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()!);
int count =2;
int num1= num;
  while (num>99)
  {
    num/=10;
    count++;
  }
    
switch(count)
{
    case 1:
    Console.Write("это просто число");
    break;
    case 2:
       
    int a1 = num1 % 10; 
    int a2 = num1 / 10;
    if (a1==a2)
    {
        Console.Write(" является палиндромом");
    }
  else
    {
        Console.Write("не является палиндромом");
    
  }
    break;
    case 3:
    {
    int a3 = num1 /100;
    int a4 = num1 % 10;
    if (a4==a3)
    {
        Console.Write("является палиндромом");
    }
    else
    {
        Console.Write("не является палиндромом");
    
  }}
    break;
    case 4:
    {
    int a5 = num1 /1000;
    int a6 = num1 % 10;
    int a7 = num1 / 100%10;
    int a8 = num1 % 100/10;
    if ((a5==a6)& (a7==a8))
   {
        Console.Write("является палиндромом");
    }
    else
    {
        Console.Write("не является палиндромом");
    
  }
  }
    break;
    case 5:
    {
    int b1 = num1 /10000;
    int b2 = num1 % 10;
    int b3 = num1 / 1000%10;
    int b4 = num1 % 100/10;

    if ((b1==b2)& (b3==b4))
   {
        Console.Write("является палиндромом");
    }
    else
    {
        Console.Write("не является палиндромом");
    
  }
  }
    break;
    case 6:
    {
    int b5 = num1 /100000;
    int b6 = num1 % 10;
    int b7 = num1 / 10000%10;
    int b8 = num1 % 100/10;
    int b9 = num1 / 1000%10;
    int b10 = num1 % 1000/100;

   // Console.Write($"{num1} {b5} {b6} {b7} {b8} {b9} {b10}");
    if ((b5==b6)& (b7==b8)&(b9==b10))
   {
        Console.Write("является палиндромом");
    }
    else
    {
        Console.Write("не является палиндромом");
    
  }
  }
    break;
    default:
    Console.Write("Введите число");
    break;
}