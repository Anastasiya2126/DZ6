/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */

Console.Write("Введите числа через запятую: ");
string? input = Console.ReadLine();
Char splitSymbol = ',';
int numbersCount = 1;
int count =0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == splitSymbol)
        numbersCount++;
}

int[] numbers = new int[numbersCount];
int numbersIndex = 0;
string subString = "";

    
for (int i = 0; i < input.Length; i++)
{
    if (input[i] == splitSymbol)
        {
            numbers[numbersIndex] = Convert.ToInt32(subString);
            subString = "";
            numbersIndex++;

        }
        else
        {
            subString += input[i];
        }
}

numbers[numbersIndex] = Convert.ToInt32(subString);
WriteArray(numbers);


void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
    
}

Console.WriteLine($"Количество чисел, больше нуля: {count}.");