// string[,] table = new string[2, 5];

// table[0,0]   table[0,1]  table[0,2]  ...  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  ...  table[1,4]
// table[2,0]   table[2,1]  table[2,2]  ...  table[2,4]
// table[3,0]   table[3,1]  table[3,2]  ...  table[3,4]

/*table[1, 2] = "слово";

for (int rows = 0; rows < 2; rows++)
    for (int columns = 0; columns < 5; columns++)
        Console.WriteLine($"-{table[rows, columns]}-");
*/

/*int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();
}*/
// альтернативная запись кода выше, через GetLength
/*
int[,] matrix = new int[3, 4];

void FillArray(int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

//PrintArray(matrix);
FillArray(matrix);
//Console.WriteLine();
PrintArray(matrix);
*/

/*
// рисуем !! 
int[,] pic = new int[,]
{
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
{0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
{0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

// этот метод какбы рисует
void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if(image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
    Console.WriteLine();
    }
}

// этот метод какбы закрашивает
void FillImage(int row, int col) // указываем два аргумента, так как далее мы будем указывать позицию строки и пиксиля.
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1; // закрашивать будем единичкой
        FillImage(row-1, col); // так мы перемещаемся по картинке указывая позицию строки и пиксиля 
        FillImage(row, col-1); // так мы перемещаемся по картинке указывая позицию строки и пиксиля 
        FillImage(row+1, col); // так мы перемещаемся по картинке указывая позицию строки и пиксиля 
        FillImage(row, col+1); // так мы перемещаемся по картинке указывая позицию строки и пиксиля 
    }
}
// выводим в терминал
PrintImage(pic);
FillImage(13, 13);
PrintImage(pic);
*/

/*
// Рекурсия!!!
double Factorial (int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1); // пишем n - 1 так как, например, 10! = 10 * 9! и тд. 
}
for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"{i}! + {Factorial(i)}");
}

Factorial(5);
*/
// так я написал с возможностью расчета факториала любого числа
/*double Factorial (double n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1); // пишем n - 1 так как, например, 10! = 10 * 9! и тд. 
}

Console.WriteLine($"Input number ");
double a = Convert.ToDouble(Console.ReadLine());
Factorial(a);
Console.WriteLine($"{a}! = {Factorial(a)}");*/

// Числа Фибоначи!
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
/*
double Fibonacci(int n)
{
    if (n == 1|| n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($" Position {i} = {Fibonacci(i)}");
}
*/