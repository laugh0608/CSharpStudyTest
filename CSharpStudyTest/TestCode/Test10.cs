namespace CsharpStudyTest.TestCode;

public class Rectangle1
{
    // 公开成员变量
    public double Length;
    public double Width;
    // 私有方法，GetArea() 仅在类 Rectangle 中使用
    private double GetArea()
    {
        return Length * Width;
    }
    public void Display()
    {
        Console.WriteLine("长度： {0}", Length);
        Console.WriteLine("宽度： {0}", Width);
        Console.WriteLine("面积： {0}", GetArea());
    }
} // Rectangle 结束

public class Test10
{
    public void TestFunction10()
    {
        Rectangle1 r = new Rectangle1();
        r.Length = 4.5;
        r.Width = 3.5;
        r.Display();
        // Console.ReadLine();
    }
}