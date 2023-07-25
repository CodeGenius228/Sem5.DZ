
int Input(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int Task = Input("Введите номер задачи: ");
Console.Clear();
switch (Task)
{
    case 1:
    {
        
        Task1();
        break;
    }
    case 2:
    {
        Task2();
        break;
    }
    case 3:
    {
        Task3();
        break;
    }
    default:
    {
        Console.WriteLine("Такого задания нет");
        break;
    }
}

void Task1()
{
    int[] ints = new int[5];
    Random rnd = new();
    int count = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(100, 1000);
        Console.Write(ints[i] + " ");
    }
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"\nОбнаружено {count} чётных числа");
}

void Task2()
{
    // Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов с нечётными индексами.

    int[] ints = new int[4];
    Random rnd = new();
    int sum = 0;
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.Next(-20, 21);
        Console.Write(ints[i] + " ");
    }
    for(int i = 0;i < ints.Length; i++)
    {
        if(ints[i] < 0)
        {
            sum += ints[i];
        }
    }
    Console.WriteLine($"\nСумма нечётных чисел равна {sum}");
}

void Task3()
{
    double[] ints = new double[5];
    int minValue = -9;
    int maxValue = 9;
    Random rnd = new();
    for (int i = 0; i < ints.Length; i++)
    {
        ints[i] = rnd.NextDouble() * (maxValue - minValue) - maxValue;
        ints[i] = Math.Round(ints[i],2);
        Console.Write(ints[i] + " ");
    }
    double max = ints[0];
    double min = ints[0];
    
    for (int i = 0; i < ints.Length; i++)
    {
        if (ints[i] > max) max = ints[i];
        else if (ints[i] < min) min = ints[i];
    }
    Console.WriteLine(max); 
    Console.WriteLine(min); 
    Console.WriteLine($"\nРазница зачений равна: {max - min} "); 
}