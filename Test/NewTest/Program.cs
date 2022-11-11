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

// Делаем все д\з заново
// Задача №1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
int BolsheMenshe(int num1, int num2)
{
    int result = 0;
    if (num1 > num2)
    {
        result = num1;
    }
    else 
    {
        result = num2;
    }
    return result;
}

Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = BolsheMenshe(num1, num2);

Console.Write($"Из двух введенных чисел {num1} и {num2} большее {result}");
*/

// Задача №2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int BolsheMenshe()
{
    Console.Write("Введите первое число ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    if (num1 > num2 & num1 > num3)
    {
        result = num1;
    }
    else if (num2 > num1 & num2 > num3)
    {
        result = num2;
    }
    else if (num3 > num1 & num3 > num2)
    {
        result = num3;
    }
    return result;
}

int result = BolsheMenshe();

Console.Write($"Большее число из введенных - это {result}");
*/

// Задача №3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
void BesOstatka()
{
    Console.Write("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.Write("Данное число является четным ");
    }
    else
    {
        Console.Write("Данное число является нечетным ");
    }
}

BesOstatka();
*/

// Задача №4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
void radNumbers()
{
    Console.Write("Введите число ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 0)
    {
        int current = 2;
        while(current <= num)
        {
            Console.Write(current + " ");
            current+=2;
        }
    }
    else if(num < 0)
    {
        int current = -2;
        while(current >= num)
        {
            Console.Write(current + " ");
            current-=2;
        }
    }
}

radNumbers();
*/

// Задача №5. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void numbers()
{
    Console.Write("Введите трехзначное число ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 99 & num < 1000)
    {
        num = num / 10 % 10;
        Console.Write(num);
    }
    else if (num < 100 | num > 999)
    {
        Console.Write("Вы ввели неверное число ");
    }
}

numbers();
*/

// Задача №6 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int numbers(int num)
{
    int result = 0;

    if(num < 99 & num > 0 || num > -99 & num < 0 )
    {
        result = 0;
    }
    else if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        result = num % 10;
    }
    else if (num < -99)
    {
        while (num < -999)
        {
            num = num / 10;
        }
        result = num % 10 *(-1);
    }
    return result;
}
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int result = numbers(num);

if (result == 0)
{
    Console.Write($"Наше число {num}, у него нет третьей цифры ");
}
else 
{
    Console.Write($"Наше число {num}, его третья цифра {result}");
}
*/

// Вариант через строку
/*
string ShowThirdDigitOfNumber(int num)
{
    string result;
    string numAsString = Convert.ToString(num);
    if (numAsString.Length < 3)
        result = "No third digit.";
    else
    {
        char third = numAsString[2];
        result = $"Third digit of {num} is {third}.";
    }
    
    return result;
}
Console.Write("Input number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
string thirdDigit = ShowThirdDigitOfNumber(numberB);
Console.WriteLine(thirdDigit);
*/

// Задача №7. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayOFWeek(int day)
{
    bool result;

    if (day == 6 || day == 7)
    {
        result = true;
    }
    else 
    {
        result = false;
    }
    return result;
}

Console.Write("Укажите цифру, обозначающую день недели ");
int day = Convert.ToInt32(Console.ReadLine());

bool result = DayOFWeek(day);

if (result)
{
    Console.Write($"{day}-й день недели, это выходной ");
}
else
{
    Console.Write($"{day}-й день недели, это не выходной ");
}
*/
// Второй вариант:
/*
void DateNumber(int num)
{
   if(num > 5 && num < 8) Console.WriteLine("This day of the week is a holiday!");
   if(num < 1 | num > 7) Console.WriteLine("There are only 7 days in a week, enter the correct number!");
   if(num >= 1 && num <= 5) Console.WriteLine("This day of the week is not a holiday!");
}

Console.Write("Enter the date ");
int a = Convert.ToInt32(Console.ReadLine());
DateNumber(a);
*/

// Задача №8. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// работает только с 5-ти значными числами
/*
void Palindrom(int num)
{
    int firstNumber = num / 10000;
    int lastNumber = num % 10;

    if (firstNumber == lastNumber)
    {
        int nextFirstNumber = num / 1000 % 10;
        int nextLastNumber = num % 100 /10;

        if(nextFirstNumber == nextLastNumber)
        {
            Console.WriteLine($"Число {num} является полиндромом ");
        }
        else
        {
        Console.WriteLine($"Число {num} не является полиндромом ");
        }
    }
    else
    {
        Console.WriteLine($"Число {num} не является полиндромом ");
    }
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Palindrom(num);
*/

// для чисел не только 5-х
// Принимаются числа любой длинны, как с четным, так и с нечетным кол-вом цифр. Это надо будет разобрать на свежую голову.
/*
bool IsThisPalindromeNumberFirstA(int num)
{
    bool res = true; // задаем результирующей переменной значение по умолчанию true
    int globalCount = 1; // эта переменная просто для отображения порядкового номера итерации цикла
    // Основной цикл. В ходе него от числа num будут отсекаться первая и последняя цифры. Когда останется одна цифра (пусть даже 0), цикл прервется, в res останется true, так как если число состоит из одной цифры, то оно является палиндромом.
    while (num > 9)
    {
        Console.WriteLine($"{globalCount} итерация. num равен {num}."); // просто для наглядности показывает чему равен num на начало итерации с номером globalCount
        int lastDigit = num % 10; // переменная, хранящая последнюю цифру
        Console.WriteLine($"Последняя цифра числа {num} является {lastDigit}."); // просто для наглядности
        int firstDigit = num; // тут будет храниться первая цифра числа, для начала просто копируем в нее num
        int countOfDigits = 0; // счетчик количества разрядов числа, пригодится позже
        // цикл для нахождения первой цифры числа numCopy. Делим в цикле firstDigit на 10 пока не останется одна цифра.
        while (firstDigit >= 10)
        {
            countOfDigits++;
            firstDigit /= 10;
        }
        Console.WriteLine($"Первой цифрой числа {num} является {firstDigit}."); // для наглядности
        // если первая и последняя цифры различаются, то прерываем цикл, в res заносим false
        if (lastDigit != firstDigit)
        {
            res = false;
            Console.WriteLine($"Первая цифра {firstDigit} и последняя цифра {lastDigit} различаются, число не палиндром."); // для наглядности
            break; // прерывает ближайший цикл (while (num > 9))
        }
        // если всё ок и цикл не прервался, находим новое значение для num, без первой и последней цифры
        // Math.Pow(10, countOfDigits - 1) дает нам число, при делении по остатку на которое num даст нам первую цифру
        // по-идее, если я все правильно написал, то ситуцации где Math.Pow(10, countOfDigits - 1) будет равно нулю не должно возникать (но это не точно)
        num = num / 10 % (Convert.ToInt32(Math.Pow(10, countOfDigits - 1)));
        Console.WriteLine($"Результат после {globalCount} итерации: {firstDigit}_{num}_{lastDigit}.");
        globalCount++;
        Console.WriteLine($"================================="); // разделитель для наглядности
    }
    return res;
}

Console.Write("Введите число, которое будем проверять на палиндром: ");
int number = Convert.ToInt32(Console.ReadLine());

bool palindromeNumber = IsThisPalindromeNumberFirstA(number); 


if (palindromeNumber)
    Console.WriteLine($"Число {number} является палиндромом.");
else
    Console.WriteLine($"Число {number} НЕ является палиндромом.");
*/

// Задача №9. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53
// Согласно теореме Пифагора: Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2))
/*
double rasstoianie(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double ab = Math.Sqrt(Math.Pow(xB - xA,2) + Math.Pow(yB - yA,2) + Math.Pow(zB - zA,2)); 
    return Math.Round(ab,2);
}

Console.Write("Введите xA ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yA ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zA ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите xB ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите yB ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите zB ");
double zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

double result = rasstoianie(xA,yA,zA,xB,yB,zB);
Console.WriteLine(result);
*/

// Задача №10. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// первый вариант
/*
void Kubs(int num)
{
    int current = 1;

    if (num > 0)
    {
        while(current <= num )
        {
            Console.Write(Math.Pow(current, 3) + " ");
            current++;
            
        }
    }
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Kubs(num);
*/
// второй вариант
/*
void Kubs(int num)
{
    int current = 1;
    int result = 0;

    if (num > 0)
    {
        while (current <= num)
        {
            result = current * current * current;
            current++;
            Console.Write(result + " " );
        }
    }
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

Kubs(num);
*/

// Задача №11. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Stepen(int numA, int numB)
{
    int current = 0;
    int result = 0;

    while(current < numB)
    {
        result = result + numA * numA;
        current++;
    }
    return result;
}

Console.Write("Введите число A ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Stepen(numA,numB);
Console.Write(result);
*/

// Задача №11.  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. ОШИБКА В РЕШЕНИИ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
/*
int Sum(int num)
{
    int current = 0;
    
    while (num > 0)
    {
        num = num / 10;
        current++;
    }
    return current;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int result = Sum(num);
Console.Write(result);
*/

// Задача №12. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray()
{
    Console.Write("Какого размера будет наш массив? ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.Write("Минимальное значение нашего массива ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное значение нашего массива ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] myArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min,max);
    }
    return myArray;
}

void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateArray();
ShowArray(myArray);
*/

// Задача №13. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArray()
{
    Console.Write("Какого размера будет наш массив? ");
    int size = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Минимальное значение нашего массива ");
    int min = 100;
    //Console.Write("Максимальное значение нашего массива ");
    int max = 999;

    int[] myArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min,max);
    }
    return myArray;
}
void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}
int EvenNumbers(int[] myArray)
{
    int current = 0;
    
    for(int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] % 2 == 0)
        {
            current++;
        }
    }
    return current;
}

int[] myArray = CreateArray();
ShowArray(myArray);

Console.WriteLine();

int result = EvenNumbers(myArray);
Console.Write(result);
*/

// Задача №14. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateArray()
{
    Console.Write("Какого размера будет наш массив? ");
    int size = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Минимальное значение нашего массива ");
    int min = 1;
    //Console.Write("Максимальное значение нашего массива ");
    int max = 10;

    int[] myArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        myArray[i] = new Random().Next(min,max);
    }
    return myArray;
}
void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}
int Sum(int[] myArray)
{
    int sum = 0;
    for (int i = 1; i < myArray.Length; i+=2)
    {
        sum = sum + myArray[i];
    }
    return sum;
}

int[] myArray = CreateArray();
ShowArray(myArray);

Console.WriteLine();

int result = Sum(myArray);
Console.Write(result);
*/
// Задача №14. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateArray()
{
    Console.Write("Какого размера будет наш массив? ");
    int size = Convert.ToInt32(Console.ReadLine());
    //Console.Write("Минимальное значение нашего массива ");
    //int min = 1;
    //Console.Write("Максимальное значение нашего массива ");
    //int max = 10;

    double[] myArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        myArray[i] = Math.Round(new Random().NextDouble() * 10,2);
    }
    return myArray;
}
void ShowArray(double[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}
double Subtraction(double[] myArray)
{
    double max = myArray[0];
    double min = myArray[0];
    double result = 0;

    for(int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > max)
        {
            max = myArray[i];
        } 
        else if (myArray[i] < min)
        {
            min = myArray[i];
        }
        result = max - min;
    }
    return result;
}

double[] myArray = CreateArray();
ShowArray(myArray);

Console.WriteLine();

double result = Subtraction(myArray);
Console.Write(result);
*/

// Дополнительная задача! Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Ну и примеры: [1 2 3 4 5] -> 5 8 3; [6 7 3 6] -> 36 21  
/*
int[] CreateArray()
{
    Console.Write("Какого размера будет наш массив? ");
    int size = Convert.ToInt32(Console.ReadLine());

    int[] myArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}
void ShowArray(int[] myArray)
{
    for(int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
    Console.WriteLine();
}
int[] NewArray(int[] myArray)
{
    int Length = myArray.Length / 2 + myArray.Length % 2;
    int[] newArray = new int[Length];*/
/*
    for (int i = 0; i < Length; i++)
    {
        if (i != myArray.Length - 1 - i)
        {
            newArray[i] = myArray[i] * myArray[myArray.Length- 1 - i];
        }
        else  
        {
            newArray[i] = myArray[i];
        }
    }
    return newArray;
}*/
/*
    int i = 0;
    int size = myArray.Length;
    int end = myArray.Length / 2;
    
    if (size % 2 != 0)
    {
        int length = size / 2 + 1;
        int[] newarray = new int[length];
        while (i < end)
        {
            newarray[i] = myArray[i] * myArray[size - 1];
            i++;
            size--;
        }
        newarray[i] = myArray[end];
        return newarray;
    }
    else
    {
        int count = size / 2;
        int[] newarray = new int[count];
        while (i < end)
        {
            newarray[i] = myArray[i] * myArray[size - 1];
            i++;
            size--;
        }
        return newarray;
    }
}
*/
/*
void ShowNewArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateArray();
ShowArray(myArray);

int[] result = NewArray(myArray);
ShowNewArray(result);*/



