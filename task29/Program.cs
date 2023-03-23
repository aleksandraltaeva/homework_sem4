// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран. (числа берете любые)

//----------метод1(приглашение ко вводу)---------
int Input(string text)
{
    Console.Write(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//----------метод2(заполнение массива)---------
int[] FillArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

//----------метод3(вывод массива на экран)---------
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i <array.Length-1; i++)
    {
        Console.Write($"{array[i]}; ");
    }
    Console.Write($"{array[array.Length-1]}]");

}
int length = Input("Введите длину массива: ");
int minValue = Input("Начало диапазона: ");
int maxValue = Input("Конец диапазона: ");
int[] array = FillArray(length, minValue, maxValue);
PrintArray(array);