int ThreeDigitNumber(int num)

{
    int n = num / 10;
    int b = n % 10;
    int c = b;

    return c;
}

int number = new Random().Next(100,999);
int digit = ThreeDigitNumber(number);

Console.WriteLine($"Вторая цифра трехзначного числа {number} это {digit}");