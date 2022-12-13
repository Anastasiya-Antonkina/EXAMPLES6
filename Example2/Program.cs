/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.WriteLine("Введите число");
string number = (Console.ReadLine());

if (!int.TryParse(number, out int val)) return;

int sum = 0;
for (int i = 0; i < number.Length; i++)
    sum += int.Parse(number[i].ToString());

Console.Write($"Сумма цифр в числе {number} равна: {sum}");