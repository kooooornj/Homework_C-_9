/* Zadacha 64
int Kolvochisel(int N)
{
    if (N / 10 != 0)
        return 1 + Kolvochisel(N / 10);
    else return 1;
}
Console.Write("Пожалуйста, введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Количетсво цифр в указанном числе: " + Kolvochisel(n1));
*/
/* Zadacha 66 
int Summa (int n, int m)
{
    if (n < m)
    {
        while (n != m)
            return n + Summa(n + 1, m);
    }

    if (n > m)
    {
        while (n != m)
            return n + Summa(n - 1, m);
    }

    return n;
}

Console.Write("Введите 1 число: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных элементов в указанном промежутке: " + Summa(n1, m1));
*/