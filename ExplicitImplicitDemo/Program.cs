using System;

namespace ExplicitImplicitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 可以隐式直接转换为 double
            Console.WriteLine($"double = {new ImplicitModel(100) + 0.0}");
            Console.WriteLine($"ImplicitModel = {(ImplicitModel)100.0}");

            // 需要显式转换为double后再计算
            Console.WriteLine($"double = {(double)new ExplicitModel(100) + 0.0}");
            Console.WriteLine($"ExplicitModel = {(ExplicitModel)100.0}");

            Console.Read();
        }
    }
}
