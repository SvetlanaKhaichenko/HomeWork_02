int three (int pol)
{
    if (pol > 1000)
    {
        while (pol > 1000)
        {
            pol = pol / 10;
        }
        int rezult = pol % 10;
        return rezult;
    }
    
    if (pol > 99)
        {
            int result = pol % 10;
            return result;
        }
    else 
        {
            int result = 0;
            return result;
        }
    }


Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int result = three (a);
if (result == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра {result}");
}