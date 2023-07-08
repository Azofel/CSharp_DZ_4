Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int copy_number = number;
do 
{
    sum = sum + number%10;
    number = number / 10;
}
while(number > 0);
Console.Write($"Сумма цифр числа {copy_number} равна: {sum} ");
