// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//----------метод1(приглашение ко вводу)---------
int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//----------метод2(подсчет суммы цифр числа)---------
int Sum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int a = Input("Введите число: ");
System.Console.WriteLine($"{a} - > {Sum(a)}");