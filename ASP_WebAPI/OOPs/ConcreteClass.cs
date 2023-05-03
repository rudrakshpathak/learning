using static System.Console;
using static ASP_WebAPI.OOPs.StaticClass;

namespace ASP_WebAPI.OOPs
{
    /**
    * 1. OOP Support: Inheritance, Polymorphism, Abstraction, Encapsulation
    */
    internal class ConcreteClass : AbstractClass
    {
        private string? _privateProperty = default;

        public string PrivatePropertyAccessor 
        {
            get 
            {
                return _privateProperty ?? "";
            }
            set
            {
                _privateProperty = value;
            }
        }

        public ConcreteClass()
        {
            WriteLine("Derived class consutrctor");
        }

        public ConcreteClass(int number) : base(number)
        {
            WriteLine("Derived class consutrctor");
        }

        public override void Method1()
        {
            WriteLine("Method1 implemented");
            WriteLine(GetApplicationName());
            WriteLine(DefaultAppName);
        }

        public void Method2()
        {

        }
    }
}
