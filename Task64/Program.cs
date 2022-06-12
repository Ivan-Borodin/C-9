Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
void NNumber (int x, int y)
{
    if (x>y) return;
    NNumber (x+1, y);
    Console.Write($"{x} ");
}
NNumber(m,n);