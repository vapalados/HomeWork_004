Console.Write("Введите число: ");
string Number = Console.ReadLine() ?? "0";
int Summ(string a)
{
    int Dlina = a.Length;
    int Summa = 0;
    for (int i = 0; i < Dlina; i++)
    {
        int n = Convert.ToInt32(Char.GetNumericValue(a[i]));
        Summa = Summa + n;
    }
    return Summa;
}
Console.WriteLine("Сумма цифр в числе = " + Summ(Number));