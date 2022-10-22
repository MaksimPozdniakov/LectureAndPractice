// Группа №1:
/*
void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1();
*/
// Группа №2:
/*
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method1("Текст сообщения ");
*/
/*
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; 
    }
}
Method21(count: 4, msg: "Текст");
*/
// Группа №3:
/*
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
*/
// Группа №4:
/*
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);
*/
// 4-й метод через цикл "for":
/*
string Method5(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "asdf");
Console.WriteLine(res);
*/

//Цикл в цикле:
/*
for (int a = 2; a <= 10; a++)
{
    for (int b = 2; b <= 10; b++)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
    Console.WriteLine();
}
*/

// Задача №1. Дан текст. В тексте нужно все пробелы заменить
//черточками, маленькие буквы "к" заменить большими "К", а 
//большие  "С" заменить маленькими "с".
/*
string text = "– Я думаю, – сказал князь, улыбаясь, – что," 
               + "ежели бы вас послали вместо нашего милого Винценгероде," 
               + "вы бы взяли приступом согласие прусского короля." 
               + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'с', 'С');
Console.WriteLine(newText);
*/

// Задача №2. Алгоритм сортировки.
// 1, 5, 4, 3, 2, 6, 7, 1, 1
/*
int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} "); 
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
PrintArray(array);
SelectionSort(array);
PrintArray(array);
*/
//Задача №3. Попробовать развернуть заачу. 