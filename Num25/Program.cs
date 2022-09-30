//Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int NumA()
{
    Console.WriteLine("Введите число А");
    return Convert.ToInt32(Console.ReadLine());
}
int NumB()
{
    Console.WriteLine("Введите число B");
    return Convert.ToInt32(Console.ReadLine());
}
int Stp(int c, int d)
{
    int step = 1;
    for (int i = 0; i < d; i++)
    {
        step = step * c;
    }
    return step;
}
int a = NumA();
int b = NumB();
int res = Stp(a,b);
Console.WriteLine($"{a} в степени {b} равно {res}!");