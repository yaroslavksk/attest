using System.Runtime.InteropServices;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
        int [] b = new int [9];
        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(a[i, j]);
                b[count++] = a[i, j];
            }
        }
        Array.Sort(b);
        Console.WriteLine();
        foreach (var i in b)
        {
            Console.WriteLine(i);
        }
    }
}