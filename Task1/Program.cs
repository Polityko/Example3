int a;
Console.WriteLine("Введите пятизначное число: ");
a = Convert.ToInt32(Console.ReadLine()); 

int num1 = a / 10000 % 10;
int num2 = a / 1000 % 10;
int num3 = a / 10 % 10;
int num4 = a % 10;
int num5 = a / 10000;

if (a < 10000 || a > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}  
else
if (num1 == num4 && num2 == num3)
{
    Console.WriteLine(a + " -> Число палиндром");
}    
else
{
    Console.WriteLine(a + " -> Не палиндром");
}