namespace CsharpStudyTest.TestCode1;

public class DivNumbers
{
    int _result;
    public DivNumbers()
    {
        _result = 0;
    }
    public void Division(int num1, int num2)
    {
        try
        {
            _result = num1 / num2;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine($"Exception caught: {e}");
        }
        finally
        {
            // 调用构造函数输出默认结果 result = 0
            Console.WriteLine($"Result: {_result}");
        }

    }
    public void TestFunction5()
    {
        DivNumbers d = new DivNumbers();
        d.Division(25, 0);
        // Console.ReadKey();
    }
}