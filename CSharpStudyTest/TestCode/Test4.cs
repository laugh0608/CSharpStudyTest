namespace CsharpStudyTest.TestCode;

public class Test4
{
    public void TestFunction4()
    {
        string str = "123.45";
        double d;
        bool success = double.TryParse(str, out d);

        if (success) {
            Console.WriteLine($"转换成功: {d}");
        } else {
            Console.WriteLine("转换失败");
        }
    }
}