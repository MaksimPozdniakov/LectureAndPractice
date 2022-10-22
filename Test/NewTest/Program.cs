// Задача №1. Напмшмте программу, которая будет изменять элементы массива с отрицательных на положительные.
/*
int[] NewArray(int size, int minValue, int maxValue)
{
    int[] myArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        //Console.Write($"Number {i+1} "); 
        //myArray[i] = Convert.ToInt32(Console.ReadLine());
        myArray[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine();
    return myArray;
}

void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}

int[] ChengeArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    { 
        myArray[i] = myArray[i] * (-1);  
    }
    return myArray;
}


Console.Write("Input size array ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -50;
int max = -5;

int[] myArray = NewArray(size, min, max);
Console.Write("Мой старый массив = ");
ShowArray(myArray);

Console.WriteLine(" ");

Console.Write("Мой новый массив = ");
int[] result = ChengeArray(myArray);
ShowArray(result);
*/

// Разобраться в методе решения

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
double[] IntersectionLines(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;
    return array;
}
void PrintIntersection(double[] array)
{
    Console.Write($"Точка пересечения = [{array[0]}; {array[1]}].");
}

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("Прямые параллельны, точки пересечения нет.");
else
{
    double[] result = IntersectionLines(b1,k1,b2,k2);
    PrintIntersection(result);
}
Console.ReadLine();
*/

// Тоже разобраться

/*
int AmountPositiveNums(int amountNum)
{
    int amount = 0;
    int count = 0;
    do
    {
        Console.Write("Введите число: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0) count++;
        amount++;
    } while (amount < amountNum);
    return count;
}

Console.Write("Введите желаемое количество чисел: ");
int amountNum = Convert.ToInt32(Console.ReadLine());
int result = AmountPositiveNums(amountNum);
Console.WriteLine($"Количество положительных чисел = {result}");
Console.ReadLine();
*/

/*
void AmountPositiveNums()
{
    Console.WriteLine("Введите число для проверки. Для завершения программы введите q.");
    int count = 0;
    int amount = 0;
    while(true)
    {
        Console.Write("Введите число: ");
        string? userInput = Console.ReadLine();
        string stop = "q";
        if(userInput != stop)
        {
            int num = Convert.ToInt32(userInput);
            if (num > 0) count++;
        }
        else 
        {
        Console.WriteLine("Ввод окончен.");
        Console.WriteLine($"Количество положительных чисел = {count}. Всего введено {amount} чисел.");
        break;
        }
        amount++;
    }
}

AmountPositiveNums();
Console.ReadLine();
*/

// в этом решении обязательно разобраться 

// Задача №4. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний 
// элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
/*
Console.Clear();
int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("Created array: { ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine("}.");
}
/*
int[] ProductElementsArray(int[] array)
{
    int i = 0;
    int size = array.Length;
    int end = array.Length / 2;
    if (size % 2 != 0)
    {
        int length = size / 2 + 1;
        int[] newarray = new int[length];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        newarray[i] = array[end];
        return newarray;
    }
    else
    {
        int count = size / 2;
        int[] newarray = new int[count];
        while (i < end)
        {
            newarray[i] = array[i] * array[size - 1];
            i++;
            size--;
        }
        return newarray;
    }
}
*/
