int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод ");
        }
    }
    return result;
}
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len =number.Length;

if (len == 5)
{
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine($"{number} - Палиндром");
}
else
{
Console.WriteLine($"{number} - Не палиндром");
}
}