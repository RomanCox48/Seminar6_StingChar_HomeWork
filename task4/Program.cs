﻿//Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке.
//В полученной строке слова должны быть также разделены пробелами.

// Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами:");
// string[] sentence = Console.ReadLine().Split(" ").ToArray();
// for (int i = 0; i < sentence.Length/2; i++)
// {
//     string temp = "";
//     temp = sentence [i];
//     sentence [i] = sentence [sentence.Length -1-i];
//     sentence [sentence.Length -1-i] = temp;
// }
// Console.WriteLine($"{string.Join(" ", sentence)}");

string ReverseWords(string input)
{
    string[] words = input.Split(' ');
    Array.Reverse(words);
    

    return string.Join(" ",words);
}

Console.Clear();
Console.Write("Введите строку: ");
string input = Console.ReadLine()!;
Console.WriteLine("Строка с перевернутыми словами: " + ReverseWords(input));