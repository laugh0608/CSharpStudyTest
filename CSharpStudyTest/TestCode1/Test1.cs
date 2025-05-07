namespace CsharpStudyTest.TestCode1;

public class TestData  
{  
    public int Add(int a, int b, int c)  
    {  
        return a + b + c;  
    }  
    public int Add(int a, int b)  
    {  
        return a + b;  
    }  
} 

public class Test1
{
    public void TestFunction1()  
    {  
        TestData dataClass = new TestData();
        int add1 = dataClass.Add(1, 2);  
        int add2 = dataClass.Add(1, 2, 3);

        Console.WriteLine($"add1 : {add1}");
        Console.WriteLine($"add2 : {add2}");  
    } 
}