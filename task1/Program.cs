//Задайте двумерный массив символов (тип char [,]).
//Создать строку из символов этого массива.

char[,] matrixChar = new char[,]
{
    {'a', 'b', 'c', 'd'},
    {'e', 'f', 'g', 'h'},
    {'i', 'j', 'k', 'l'}
};

string JoinChar(char[,] matrixChar, string str)
{
    for (int i = 0; i < matrixChar.GetLength(0); i++)
    {
        for (int j = 0; j < matrixChar.GetLength(1); j++)
        {
            str += matrixChar[i, j];
        }
    }
    return str;
}

string str = "";
string newStr = JoinChar(matrixChar, str);
Console.WriteLine(newStr);