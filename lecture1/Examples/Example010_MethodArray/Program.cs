int[] array = {1, 55, 12, 4, 16, 87, 59, 18};
int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}