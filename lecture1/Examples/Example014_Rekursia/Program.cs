// Перебор слов (надо выфснить как это сделать)
/*
char[] s = ('ф','и','с','в');
int count = s.Length;
int n = 1;
for(int i = 0; i<count; i++)
{
    for (int j = 0; j < count; j++)
    {
        Console.WriteLine($"{n++,-5} {s[i]} {s[j]}");
    }
}
*/
//задача задача показывает все варианты комбинацци данных чисел
/*
int n = 1;
void FindTeam(string team, char[] team2, int length = 0)
{
    if (length == team2.Length)
    {
        Console.WriteLine($"{n++} {new String(team2) }"); return;
    }

    for (int i = 0; i < team.Length; i++)
    {
        team2[length] = team[i];
        FindTeam(team, team2, length + 1);
    }
}

FindTeam("12345", new char[2]);
*/
//Создаем поиск, обходим директории
 /* в этой части мы можем просмотреть файлы в первой папке
 string path = "C:/Users/PMPav/Desktop/Учеба";
 DirectoryInfo di = new DirectoryInfo(path);
 Console.WriteLine(di.CreationTime);
 FileInfo[] fi = di.GetFiles();
 for (int i = 0; i < fi.Length; i++)
 {
    Console.WriteLine(fi[i].Name);
 }*/
/* во всех папках
 void CatalogInfo(string path, string indent = "")
 {
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent +" ");
    }
    FileInfo[] files = catalog.GetFiles();

    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
 }

 string path = "C:/Users/PMPav/Desktop/Учеба";
 CatalogInfo(path);
 */

 // пирамидки
/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/
// обход дерева
/*
string emp = string.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}

InOrderTraversal();
*/