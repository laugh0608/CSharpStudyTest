namespace CsharpStudyTest.TestCode;

class Shape 
{
    public void SetWidth(int w)
    {
        Width = w;
    }
    public void SetHeight(int h)
    {
        Height = h;
    }
    protected int Width;
    protected int Height;
}

// 基类 PaintCost
public interface IPaintCost 
{
    int GetCost(int area);

}
// 派生类
 class Rectangle3 : Shape, IPaintCost
{
    public int GetArea()
    {
        return (Width * Height);
    }
    public int GetCost(int area)
    {
        return area * 70;
    }
}

public class Test19
{
    public void TestFunction19()
    {
        Rectangle3 rect = new Rectangle3();
        int area;
        rect.SetWidth(5);
        rect.SetHeight(7);
        area = rect.GetArea();
        // 打印对象的面积
        Console.WriteLine($"总面积：{rect.GetArea()} m2");
        Console.WriteLine($"油漆总成本：{rect.GetCost(area)} $");
        // Console.ReadKey();
    }
}