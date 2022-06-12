Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}
int akk = Akkerman(n, m);
Console.WriteLine(akk);
