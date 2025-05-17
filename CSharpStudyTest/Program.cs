
namespace CsharpStudyTest;

internal abstract class Program
{
    // Main() 函数必须是静态的
    private static void Main()
    {
        // 静态方法中不能调用非静态方法，除非通过创建类的实例实例来调用
        // TestCode.Test19 obj = new TestCode.Test19();
        // obj.TestFunction19();
        // 在非静态方法或静态方法中调用静态方法应该通过类名直接调用，而不是通过实例对象调用
        // TestCode.Test1.TestFunction1();
        
        var obj = new _20250517.MatrixTest();
        obj.TestMatrix();
    }
}