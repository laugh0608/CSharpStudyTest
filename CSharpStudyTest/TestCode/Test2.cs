namespace CsharpStudyTest.TestCode;

public class Test2
{
    public void TestFunction2()
    {
        double doubleValue = 3.14;
        int intValue = (int)doubleValue; // 强制从 double 到 int，数据可能损失小数部分
        Console.WriteLine("doubleValue: {0:G}", doubleValue);   // G 表示一般输出
        Console.WriteLine($"doubleValue: {doubleValue:F1}");    // F1 表示保留一位小数
        Console.WriteLine("intValue: " + intValue);
        Console.WriteLine($"intValue: {intValue}");
        Console.WriteLine($"{intValue} + {doubleValue:G}");
        // 格式化字符串，最推荐的就是插值，使用 $ 符号开头，并在字符串中直接使用 {} 包裹变量名
        // Console.ReadLine();
    }
}