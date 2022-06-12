Console.WriteLine("Введите 1 число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int n = Convert.ToInt32(Console.ReadLine());
void SumNumber(int numM, int numN, int sum)
{
    if (numM == numN)
    {
        sum = sum + numM;
        Console.WriteLine(sum);
        return;
    }
    if (numN > numM)
    {
        sum = sum + numM;
        SumNumber(numM + 1, numN, sum);
    }
    if (numM > numN)
    {
        sum = sum + numM;
        SumNumber(numM - 1, numN, sum);
    }
}
SumNumber(m, n, 0);
