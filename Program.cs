Console.WriteLine("Введите символьный массив, разделяя его пробелами: ");
string? text = Console.ReadLine();
string[] ChooseThreeCharWords(string s)
{
    string[] subs = s.Split(' ');
    string resultstring = "";
    for (int i = 0; i < subs.Length; i++)
    {
        if (subs[i].Length <= 3)
        {
            resultstring = resultstring.Insert(0, $" {subs[i]}");
        }
    }
    string[] result = resultstring.Split(' ');
    return result;
}


string[] resulttext = ChooseThreeCharWords(text);
Console.Write($"Искомый массив:");
for (int j = 0; j < resulttext.Length; j++)
{
    Console.Write($" {resulttext[j]}");
}
Console.WriteLine();


