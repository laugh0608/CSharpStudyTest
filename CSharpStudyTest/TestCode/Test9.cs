namespace CsharpStudyTest.TestCode;

public class Test9
{
    public void TestFunction9()
    {
        // 输出 2-10 的质数
        int i, j;

        for (i = 2; i < 10; i++)
        {
            for (j = 2; j <= (i / j); j++)
            {
                if ((i % j) == 0)
                {
                    break; // 如果找到，则不是质数
                }
            }
            if (j > (i / j))
            {
                Console.WriteLine($"{i} 是质数");
            }
        }
    }
}