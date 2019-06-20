namespace ExplicitImplicitDemo
{
    public class ExplicitModel
    {
        /* explicit 关键字声明必须通过显示的调用用户定义的类型转换运算符来进行转换。
         */

        public ExplicitModel(double value)
        {
            this.Value = value;
        }

        public double Value { get; }

        public static explicit operator double(ExplicitModel model)
        {
            return model.Value;
        }

        public static explicit operator ExplicitModel(double value)
        {
            return new ExplicitModel(value);
        }

        public override string ToString()
        {
            return $"my value is {this.Value}";
        }
    }
}
