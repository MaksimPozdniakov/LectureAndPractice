// Задача №1. Напмшмте программу, которая будет изменять элементы массива с отриуательных на положительные.
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
// Задача №2. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Amount(int size)
{
    int count = 0;

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} число ");
        int number = Convert.ToInt32(Console.ReadLine());
            if(i > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел будем проверять? ");
int size = Convert.ToInt32(Console.ReadLine());
int result = Amount(size); 
Console.WriteLine($"Количество положительных чисел {result}");
*/

// теперь тоже самое только через массив.
/*
int[] CreateArray()
{
    Console.Write("Сколько чисел будем проверять? ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальный эллемент массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальный эллемент массива ");
    int max = Convert.ToInt32(Console.ReadLine());
    
    int[] myArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min, max); 
    }
    return myArray;
}

void ShowArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

int PozitivNumbers(int[] myArray)
{
    int count = 0;

    for(int i = 0; i <= myArray.Length; i++)
    {
        if(i > 0) count++;
    }
    return count;
}

int[] myArray = CreateArray();
ShowArray(myArray);

Console.WriteLine();

int result = PozitivNumbers(myArray);

Console.Write($"Количество положительных чисел = {result}");
*/

