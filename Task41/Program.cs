//считает количество положительных введенных чисел
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
int cnt = 0;
for (int i = 0; i < M; i++)
{
    int ch = Convert.ToInt32(Console.ReadLine());
    if (ch > 0)
        cnt += 1;
}
Console.WriteLine($"Количество чисел больше нуля - {cnt}");
