namespace CsharpStudyTest.TestCode1;

public class TestTemperature
{
    public void TestFunction6()
    {
        Temperature temp = new Temperature();
        try
        {
            // 1 调用 Temperature 类的 ShowTemp() 函数
            temp.ShowTemp();
        }
        // 5 捕获到异常，创建一个异常 TempIsZeroException 的实例 e
        catch(TempIsZeroException e)
        {
            // 6 输出异常实例 e 的错误信息，Message 为异常的固定返回格式，或一个空的字符串
            Console.WriteLine($"TempIsZeroException: {e.Message}");
        }
        // Console.ReadKey();
    }
}

public class TempIsZeroException: ApplicationException
{
    public TempIsZeroException(string message): base(message)
    {
    }
}

public class Temperature
{
    // 2 故意设置 _temperature 为 0 触发异常
    int _temperature = 0;
    public void ShowTemp()
    {
        if(_temperature == 0)
        {
            // 3 如果 _temperature 为 0 则创建一个异常，传入要显示的信息给 message
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            // 4 如果 _temperature 不为 0 的时候直接输出其值
            Console.WriteLine($"Temperature: {_temperature}");
        }
    }
}