void ThirdDigitNumber(int number)
{
if(number<100) Console.WriteLine("Третьей цифры в данном числе нет");
if (number>99) 
{
int index = 2;
string s1 = Convert.ToString(number);
Console.WriteLine($"Третья цифра числа {s1} это {s1[index]}");
}
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigitNumber(num);
