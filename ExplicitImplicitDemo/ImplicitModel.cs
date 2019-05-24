namespace ExplicitImplicitDemo
{
    public class ImplicitModel
    {
        /* implicit 关键字用于声明隐式的用户自定义的类型转换运算符。 
         * 如果可以确保转换过程不会造成数据丢失，则可使用该关键字在用户定义类型和其他类型之间进行隐式转换。
         * 使用隐式转换操作符之后，在编译时会跳过异常检查，所以隐式转换运算符应当从不引发异常并且从不丢失信息，否则在运行时会出现一些意想不到的问题。
         */

        public ImplicitModel(double value)
        {
            this.Value = value;
        }

        public double Value { get; }

        public static implicit operator double(ImplicitModel model)
        {
            return model.Value;
        }

        public static implicit operator ImplicitModel(double value)
        {
            return new ImplicitModel(value);
        }

        public override string ToString()
        {
            return $"my value is {this.Value}";
        }
    }
}
