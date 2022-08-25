int to (int c)
{
    int result1 = c /10;
    int result = result1 % 10;
    return result;
}


Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int result = to (a);
Console.WriteLine ($"Вторая цифра числа {result}");