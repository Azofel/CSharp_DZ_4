Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int copy_b = b;
int result = 1;
if (b < 1)
Console.Write("Число B должно быть больше или равно 1");
else
{
    while (b != 0)
    {
        result = result * a;
        b = b - 1;
    }
    Console.Write($"Число {a} в степени {copy_b} равно {result}");    
}
