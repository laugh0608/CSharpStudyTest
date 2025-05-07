namespace CsharpStudyTest.TestCode;

class Rectangle4
{
    // 成员变量
    protected double Length;
    protected double Width;
    public Rectangle4(double l, double w)
    {
        Length = l;
        Width = w;
    }
    public double GetArea()
    {
        return Length * Width;
    }
    public void Display()
    {
        Console.WriteLine($"长度：{Length}");
        Console.WriteLine($"宽度：{Width}");
        Console.WriteLine($"面积：{GetArea()}");
    }
} 
class Tabletop : Rectangle4
{
    // private double cost;
    public Tabletop(double l, double w) : base(l, w)
    { }
    public double GetCost()
    {
        double cost;
        cost = GetArea() * 70;
        return cost;
    }
    public new void Display()
    {
        base.Display();
        Console.WriteLine($"成本：{GetCost()}");
    }
}

public class Test20
{
    public void TestFunction20()
    {
        // 在实例化子类时，把参数传给构造函数的变量 l 和 w
        Tabletop t = new Tabletop(4.5, 7.5);
        t.Display();
        // Console.ReadLine();
    }
}