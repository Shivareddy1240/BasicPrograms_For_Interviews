using System.Collections;
using BasicPrograms_For_Interviews;

namespace BasicPrograms;

public class Program
{
   
    static void Main(string[] args)
    {
        StringReverse stringReverse = new StringReverse();
        Console.WriteLine("Please enter a string to reverse");
        string input = Console.ReadLine();
        stringReverse.ReverseUsingStack(input);
        Console.WriteLine("Please enter a string to reverse");
        string input2 = Console.ReadLine();
        stringReverse.ReverseStringForLoop(input2);
        Console.WriteLine("Please enter a string to reverse");
        string input3 = Console.ReadLine();
        stringReverse.ReverseStringWhileLoop(input3);
    }
    
}