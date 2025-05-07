namespace CsharpStudyTest.TestCode;

public class Test5
{
    class SampleClass
    {
        // x，y，c1，c2 为类 SampleClass 的成员
        public int X;
        public int Y;
        public const int C1 = 5;
        public const int C2 = C1 + 5;    // c2 = 10

        public SampleClass(int p1, int p2) 
        {
            X = p1; 
            Y = p2;
        }
    }

    public void TestFunction5()
    {
        // 把 11 赋给 mC.x，22 赋给 mC.y
        SampleClass mC = new SampleClass(11, 22);
        // 打印变量 x，y 的值
        Console.WriteLine($"x = {mC.X}, y = {mC.Y}");
        // 打印常量 c1，c2 的值
        Console.WriteLine($"c1 = {SampleClass.C1}, c2 = {SampleClass.C2}");
    }
}