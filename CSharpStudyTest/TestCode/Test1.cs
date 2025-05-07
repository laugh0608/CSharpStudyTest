namespace CsharpStudyTest.TestCode
{
    public class Test1
    {
        // 非静态函数，在 Main 函数中调用必须要先实例化
        public void TestFunction1()
        {
            Console.WriteLine("Size of int: {0}", sizeof(int));
            // Console.ReadLine();
        }
    }
}