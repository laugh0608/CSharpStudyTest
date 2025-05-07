namespace CsharpStudyTest.TestCode;

public class Test16
{
    public void TestFunction16()
    {
        // 一个带有 5 行 2 列的数组
        int[,] a = new int[5, 2] { {0,0}, {1,2}, {2,4}, {3,6}, {4,8} };

        int i, j;

        // 输出数组中每个元素的值
        for (i = 0; i < 5; i++)
        {
            for (j = 0; j < 2; j++)
            {
                Console.WriteLine($"a[{i},{j}] = { a[i,j] }");
            }
        }
        // Console.ReadKey();
    }
}