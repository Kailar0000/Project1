string? test(string[] s)
{
    string? a="TEST";
    for(int i=0; i<s.Length; i++)
    {
        if(s[i].Length<4)
        {
            if(a!="TEST")
            a=a+", "+s[i];
            else
            a=s[i];
        }
    }
    return a;
}

void PrintMatrix(string[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.WriteLine(matrix[i]);
    }
}

Console.WriteLine("Ведите элементы массива через , :");
string[] s = Console.ReadLine().Split(", ");
string? a=test(s);
string[] b=a.Split(", ");
PrintMatrix(b);