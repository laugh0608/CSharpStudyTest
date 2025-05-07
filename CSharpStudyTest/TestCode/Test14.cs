namespace CsharpStudyTest.TestCode;

public class Test14
{
    public void TestFunction14()
    {
        int? num1 = null;
        int? num2 = 45;
        double? num3 = new double?();
        double? num4 = 3.14157;
         
        bool? boolval = new bool?();

        // 显示值
        Console.WriteLine($"显示可空类型的值： {num1}, {num2}, {num3}, {num4}");
        Console.WriteLine($"一个可空的布尔值： {boolval}");
        // Console.ReadLine();
    }
}