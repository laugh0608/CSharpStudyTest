﻿namespace CsharpStudyTest.TestCode;

public class Test7
{
    public void TestFunction7()
    {
        char grade = 'B';

        switch (grade)
        {
            case 'A':
                Console.WriteLine("很棒！");
                break;
            case 'B':
            case 'C':
                Console.WriteLine("做得好");
                break;
            case 'D':
                Console.WriteLine("您通过了");
                break;
            case 'F':
                Console.WriteLine("最好再试一下");
                break;
            default:
                Console.WriteLine("无效的成绩");
                break;
        }
        Console.WriteLine($"您的成绩是 {grade}");
    }
}