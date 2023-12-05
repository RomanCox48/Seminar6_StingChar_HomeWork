//Задайте произвольную строку.
//Выясните, является ли она палиндромом.

void StringConvertion(string str, char [] res)
{
    for (int i = 0; i < str.Length; i++)
    {
        res[i] = str[i];
    }
}
bool CheckPalindrome(char[] res)
{
    bool isPalindrome = true;
    for (int i = 0; i < res.Length / 2; i++)
    {
        if (res[i] != res[res.Length - 1 - i])
        {
            isPalindrome = false;
            break;
        }
    }
    return isPalindrome;
}
Console.WriteLine("Введите произвольное слово:");
string str = Console.ReadLine();
char[] res = new char[str.Length];

StringConvertion(str, res);
if (CheckPalindrome(res))
    Console.WriteLine($"Строка {str} - является палиндромом.");
else
    Console.WriteLine($"Строка {str} - не является палиндромом.");


