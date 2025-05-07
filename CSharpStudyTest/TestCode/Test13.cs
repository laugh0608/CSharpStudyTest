namespace CsharpStudyTest.TestCode;

public class Test13
{
    public void Swap(ref int x, ref int y)
    {
        int temp;

        temp = x; /* 保存 x 的值 */
        x = y;    /* 把 y 赋值给 x */
        y = temp; /* 把 temp 赋值给 y */
    }
   
    public void TestFunction13()
    {
        Test13 n = new Test13();
        /* 局部变量定义 */
        int a = 100;
        int b = 200;

        Console.WriteLine("在交换之前，a 的值： {0}", a);
        Console.WriteLine("在交换之前，b 的值： {0}", b);

        /* 调用函数来交换值 */
        n.Swap(ref a, ref b);

        Console.WriteLine("在交换之后，a 的值： {0}", a);
        Console.WriteLine("在交换之后，b 的值： {0}", b);
 
        // Console.ReadLine();

    }
}