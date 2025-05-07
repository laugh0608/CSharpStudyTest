namespace CsharpStudyTest.TestCode;

public class Test3
{
    public void TestFunction3()
    {
        // 定义一个整型变量
        int i = 75;
           
        // 定义一个浮点型变量
        float f = 53.005F;
           
        // 定义一个双精度浮点型变量
        double d = 2345.7652;
           
        // 定义一个布尔型变量
        bool b = true;
        
        // 两种方式
        // string s = i.ToString();
        // string s = Convert.ToString(i);
        // 第一种实例方法，第二种是静态方法
        // 第一种支持字符串格式化，第二种仅是简单的类型转换

        // 将整型变量转换为字符串并输出
        Console.WriteLine($"i.ToString: {i.ToString()}");
           
        // 将浮点型变量转换为字符串并输出
        Console.WriteLine($"f.ToString: {f.ToString()}");
           
        // 将双精度浮点型变量转换为字符串并输出
        string str1 = Convert.ToString(d);
        Console.WriteLine($"d.ToString: {str1}");
           
        // 将布尔型变量转换为字符串并输出
        string str2 = Convert.ToString(b);
        Console.WriteLine($"b.ToString: {str2}");
    }
}