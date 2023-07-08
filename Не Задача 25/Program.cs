Console.Write("Введите число A: ");
int number_a = Convert.ToInt32(Console.ReadLine()); // Получили А

Console.Write("Введите число B: ");
int number_b = Convert.ToInt32(Console.ReadLine()); // Получили B


int result = 1;

for (int a = 0; a <= b; a++)
{
    result = result * a;
}

Console.WriteLine($"{number_a} возведя в степень {number_b} равно {result}");