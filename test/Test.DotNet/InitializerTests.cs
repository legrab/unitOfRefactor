using Shouldly;

namespace Test.DotNet;

public class Tests
{
    private const string Initializer = "initializer";
    private const string Constructor = "constructor";

    private class MyClass
    {
        public class InnerClass
        {
            private const string InnerInitializer = "inner initializer";
            public InnerClass(string when)
            {
                When = when;
            }

            public string When { get; } = InnerInitializer;
        }

        public string _field = Initializer;

        public InnerClass _innerClassAsProperty = new(Initializer);
        public string Property { get; } = Initializer;

        public InnerClass InnerClassAsProperty { get; } = new(Initializer);

        public MyClass()
        {
            _field = Constructor;
            Property = Constructor;

            _innerClassAsProperty = new InnerClass(Constructor);
            InnerClassAsProperty = new InnerClass(Constructor);
        }
    }

    [Test]
    public void TestVarousInitializersVersusConstructor()
    {
        var testClass = new MyClass();
        testClass._field.ShouldBe(Constructor);
        testClass.Property.ShouldBe(Constructor);

        testClass._innerClassAsProperty.When.ShouldBe(Constructor);
        testClass.InnerClassAsProperty.When.ShouldBe(Constructor);
    }
}
