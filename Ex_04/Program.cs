Console.WriteLine("Введите число из шести цифр");
int a = Convert.ToInt32(Console.ReadLine());

int [] mass1 = new int [6];
    mass1 [5] = a % 10;
    a = a / 10;
    mass1 [4] = a % 10;
    a = a / 10;
    mass1 [3] = a % 10;
    a = a / 10;
    mass1 [2] = a % 10;
    a = a / 10;
    mass1 [1] = a % 10;
    a = a / 10;
    mass1 [0] = a;

if (mass1 [5] == mass1[0] && mass1[4] == mass1 [1] && mass1[3] == mass1[2])
{
    Console.WriteLine ("Число является палиндромом");
}
else
{
    Console.WriteLine ("Число не является палиндромом");
}