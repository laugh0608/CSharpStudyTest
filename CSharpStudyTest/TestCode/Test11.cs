namespace CsharpStudyTest.TestCode;

public class Rectangle2
{
    // 私有成员变量
    private double _length;
    private double _width;

    // 公有方法，用于从用户输入获取矩形的长度和宽度，需要被 Main() 函数调用
    public void AcceptDetails()
    {
        Console.WriteLine("请输入长度：");
        _length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("请输入宽度：");
        _width = Convert.ToDouble(Console.ReadLine());
    }

    // 私有方法，用于计算矩形的面积，不需要被 Main() 函数调用
    private double GetArea()
    {
        return _length * _width;
    }

    // 公有方法，用于显示矩形的属性和面积，需要被 Main() 函数调用
    public void Display()
    {
        Console.WriteLine($"长度： {_length}");
        Console.WriteLine($"宽度： {_width}");
        Console.WriteLine($"面积： {GetArea()}");
    }
}

public class Test11
{
    public void TestFunction11()
    {
        // 创建 Rectangle 类的实例
        Rectangle2 r = new Rectangle2();
        // 通过公有方法 AcceptDetails() 从用户输入获取矩形的长度和宽度
        r.AcceptDetails();
        // 通过公有方法 Display() 显示矩形的属性和面积
        r.Display();
        // Console.ReadLine();
    }
}