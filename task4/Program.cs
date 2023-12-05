//Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке.
//В полученной строке слова должны быть также разделены пробелами.

Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами:");
string[] sentence = Console.ReadLine().Split(" ").ToArray();
for (int i = 0; i < sentence.Length/2; i++)
{
    string temp = "";
    temp = sentence [i];
    sentence [i] = sentence [sentence.Length -1-i];
    sentence [sentence.Length -1-i] = temp;
}
Console.WriteLine($"{string.Join(" ", sentence)}");

