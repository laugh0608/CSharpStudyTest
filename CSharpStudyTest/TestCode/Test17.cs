namespace CsharpStudyTest.TestCode;

public class Test17
{
    // 将数组 balance 当作参数传给 arr，将数组长度 5 传给 size
    double GetAverage(int[] arr, int size)
    {
        int i;
        double avg;
        int sum = 0;
        // 计算数组中元素的和
        for (i = 0; i < size; ++i)
        {
            sum += arr[i];
        }
        // 计算平均值
        avg = (double)sum / size;
        // 返回平均值
        return avg;
    }
    public void TestFunction17()
    {
        // 实例化类 MyArray，命名为 app
        Test17 app = new Test17();
        // 一个带有 5 个元素的 int 数组
        int[] balance = new[]{1000, 2, 3, 17, 50};
        double avg;

        // 传递数组的指针作为参数
        avg = app.GetAverage(balance, 5 ) ;

        // 输出返回值
        Console.WriteLine($"平均值是：{avg}");
        // Console.ReadKey();
    }
}