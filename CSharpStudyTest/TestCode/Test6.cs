﻿namespace CsharpStudyTest.TestCode;

public class Test6
{
    public void TestFunction6()
    {
        int a = 21;
        int b = 10;
        int c;

        c = a + b;
        Console.WriteLine($"Line 1 - c 的值是 {c}");
        c = a - b;
        Console.WriteLine($"Line 2 - c 的值是 {c}");
        c = a * b;
        Console.WriteLine($"Line 3 - c 的值是 {c}");
        c = a / b;
        Console.WriteLine($"Line 4 - c 的值是 {c}");
        c = a % b;
        Console.WriteLine($"Line 5 - c 的值是 {c}");

        // ++a 先进行自增运算再赋值
        c = ++a;
        Console.WriteLine($"Line 6 - c 的值是 {c}");

        // 此时 a 的值为 22
        // --a 先进行自减运算再赋值
        c = --a;
        Console.WriteLine($"Line 7 - c 的值是 {c}");
    }
}