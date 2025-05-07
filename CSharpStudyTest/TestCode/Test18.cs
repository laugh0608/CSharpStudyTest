namespace CsharpStudyTest.TestCode;

class StaticVar
{
    // public static int Num;
    public int Num;
    public void Count()
    {
        Num++;
    }
    public int GetNum()
    {
        return Num;
    }
}

public class Test18
{
    public void TestFunction18()
    {
        StaticVar s1 = new StaticVar();
        StaticVar s2 = new StaticVar();
        s1.Count();
        s1.Count();
        s1.Count();
        // 当 Num 为非静态时，即使 s1 的 num 这里已经是 3 了，下面 s2 的 num 也是会从 0 开始
        // 当 Num 为静态时，则这里的 s1 将 num 计算到 3，s2 则会继续读取 3 开始计算，不会重新初始化，最后 s1 和 s2 的输出值为 num 的最终值
        s2.Count();
        s2.Count();
        s2.Count();         
        Console.WriteLine($"s1 的变量 num： {s1.GetNum()}");
        Console.WriteLine($"s2 的变量 num： {s2.GetNum()}");
        // Console.ReadKey();
    }
}