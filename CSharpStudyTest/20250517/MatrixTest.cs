
using MathNet.Numerics.LinearAlgebra;

namespace CsharpStudyTest._20250517;

public class MatrixTest
{
    public void TestMatrix()
    {
        var m = Matrix<double>.Build;

        var pArray = m.DenseOfArray(new[,]{
            {1.0,2.0,1.0},
            {-2.0,-3.0,1.0},
            { 3.0,5.0,0.0}
        });

        pArray.Rank();
        pArray.Range();

        var v = pArray.Range();
        
        Console.WriteLine("Matrix rows as vectors:");
        // 遍历数组 v 并输出每个向量
        foreach (var rowVector in v)
        {
            Console.WriteLine(rowVector);
        }
    }
}