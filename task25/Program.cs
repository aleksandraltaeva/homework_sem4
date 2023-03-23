// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// (Задачи, решенные через Math.Pow, не будут считаться правильными,
// так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//----------метод1(приглашение ко вводу)---------
int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//----------метод2(возведение в степень)---------
int PowerOf(int powerbase, int power)
{
    int result = 1;

    for(int i = 0; i<power; i++)
    {
        result = result*powerbase;
    }
    return result;
}

//----------метод3(проверка степени)---------
bool Condition(int power)
{
    if (power < 0)
    {
        Console.WriteLine("Степень должна быть больше нуля.");
        return false;
    }
    return true;
}

int a = Input("Введите число: ");
int b = Input("Введите степень: ");
if (Condition(b))
{
    Console.WriteLine($"{a}, {b} -> {PowerOf(a, b)}");
}