namespace CsharpStudyTest.TestCode;

public class Test8
{
    // 处理输入错误的方法不完善，一般来说可以封装为一个方法：
    // static string GetValidInput()
    // {
    //     string? input;
    //
    //     while (true)
    //     {
    //         Console.Write("请输入内容：");
    //         input = Console.ReadLine();
    //
    //         if (!string.IsNullOrWhiteSpace(input))
    //         {
    //             return input; // 返回有效输入
    //         }
    //
    //         Console.WriteLine("输入不能为空，请重新输入！");
    //     }
    // }
    // 在调用时
    // names[i] = GetValidInput();
    public void TestFunction8()
    {
        // 定义一个变量 count 存放数组长度
        int count;
        // 读取用户输入的数字，赋值给 count
        Console.WriteLine("输入要登记的学生数：");
        // count = int.Parse(Console.ReadLine());
        // 处理输入类型无法转换为整数的情况
        if (int.TryParse(Console.ReadLine(), out count))
        {
            // YES
        } else
        {
            Console.WriteLine("输入错误，请重新输入。");
        }
        // 创建一个字符串数组 names，数组长度为变量 count
        string[]names = new string[count];
        // 通过 for 循环让用户输入数组 names 的所有元素
        for (int i = 0; i < names.Length; i++)
        {
            int num = i + 1;
            Console.WriteLine($"请输入第{num}个学生的姓名");
            // names[i] = Console.ReadLine();
            // 处理输入为 null 的情况
            string? input = Console.ReadLine();
            if (input != null)
            {
                names[i] = input;
            }
            else
            {
                Console.WriteLine("输入错误，请重新输入。");
            }
        }
        // 通过 foreach 遍历输出数组 names 中每一个元素
        Console.WriteLine("已登记的学生如下");
        foreach (string name in names)
        {
            Console.WriteLine($"{name}");
        }
    }
}