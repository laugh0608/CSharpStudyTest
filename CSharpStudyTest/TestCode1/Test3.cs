namespace CsharpStudyTest.TestCode1;

using System.Text.RegularExpressions;

public class Test3
{
    public void TestFunction3()
    {
        string input = "1851 1999 1950 1905 2003";
        string pattern = @"(?<=19)\d{2}\b";

        foreach (Match match in Regex.Matches(input, pattern))
            Console.WriteLine(match.Value);
    }
    public void TestFunction4()
    {
        string input = "Hello   World   !";
        string pattern = "\\s+";
        string replacement = " ";
        Regex rgx = new Regex(pattern);
        string result = rgx.Replace(input, replacement);

        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Replacement String: {result}");    
        // Console.ReadKey();
    }
}