namespace VeeamCourse.Lab_1_1
{
    class MyImmutableType
    {

        public int SomeField { get; private set; }

        public MyImmutableType SetSomeField(int newValue) => new() { SomeField = newValue };

        public override string ToString()
        {
            return this.SomeField.ToString();
        }
    }
}
