namespace CsharpStudyTest.TestCode;

public class Test15
{
    public void TestFunction15()
    {
        int []  n = new int[10]; // n 是一个带有 10 个整数的数组
        int i,j;


        // 初始化数组 n 中的元素      
        for ( i = 0; i < 10; i++ )
        {
            n[ i ] = i + 100;
        }

        // 输出每个数组元素的值
        for (j = 0; j < 10; j++ )
        {
            Console.WriteLine($"Element[{j}] = {n[j]}");
        }
        // Console.ReadKey();
    }
}