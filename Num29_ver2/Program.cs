int[] FillArray()
{
    int[] Massiv = new int[8];
    Random rnd = new Random();
    for (int i = 0; i<8; i++)
    {
        Massiv[i]=rnd.Next(0,100);
    }
    return Massiv;
}
void PrintArray(int[] mass)
{
    for (int i = 0; i<8; i++)
    {
        
        Console.Write("["); 

        Console.Write(mass[i]);
        
        Console.Write("]");
    }
}
int [] mas = FillArray();
PrintArray(mas);