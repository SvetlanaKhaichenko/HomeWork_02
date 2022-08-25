int isk (int pol)
{
    if (pol > 7)
  { 
    if (pol % 7 == 0)
     {
        pol = 7;
        return pol;
     }
    else
    {
    int res1 = pol / 7;
    int x = res1 * 7;
    int result = pol - x;
    return result;
    }
  }
    else 
    {
        return pol;
    }
}

int pok (int res)
{
int [] week = { 1, 2, 3, 4, 5, 6, 7 };
int count = 6;
int n = 0;
while (n < count)
{
    if (res == week [5])
    {
        res = 1;
        break;
        
    }
    if (res == week [6])
    {
        res = 1;
        break;
    }
    else 
    {
        res = 0;
    }
    n++;
    
}
return res;
}
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int res1 = isk (a);
int result = pok (res1);


if (result == 1)
{
    Console.WriteLine("Урра, выходной");
}
if (result == 0)
{
    Console.WriteLine("Еще будни");
}