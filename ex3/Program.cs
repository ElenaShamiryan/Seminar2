int DaysOfWeek(int a)
{
int result = a;
if (a <= 5) Console.WriteLine("Этот день является рабочим");
if (a >= 6 && a<=7) Console.WriteLine("Этот день является выходным");
if (a>=8) Console.WriteLine("Введите число от 1 до 7");
return result;
}

Console.WriteLine("Введите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());
int days = DaysOfWeek(number);
