using static System.Console;

namespace ASP_WebAPI.OOPs
{
    /*
     * 1. OOP Support: Inheritance, Polymorphism, Abstraction, Encapsulation
     * 2. Can't have different base classes
     * 3. All the classes gets merged at the runtime
     * 4. Follows rest of the the properties of a Generic class
     */
    internal partial class PartialClass : AbstractClass
    {
        private string _privateProperty = "PrivatePartialMember";

        public PartialClass()
        {
            WriteLine("PARTIAL CLASS CONSTRUCTOR");
        }

        public override void Method1()
        {
            WriteLine("PARTIAL CLASS OVERRIDDEN METHOD1");
        }
    }

    internal partial class PartialClass
    {
        public void Method1(string data)
        {
            WriteLine("PARTIAL CLASS METHOD1");
        }
    }

    internal partial class PartialClass
    {
        public void Method2()
        {
            WriteLine($"PARTIAL CLASS METHOD2 PRINTING PARTIAL CLASS1 PRIVATE PROPERTY:: {_privateProperty}");
        }
    }
}
