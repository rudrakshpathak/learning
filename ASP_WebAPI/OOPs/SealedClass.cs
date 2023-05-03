using static System.Console;

namespace ASP_WebAPI.OOPs
{
    /*
     * 1. OOP Support: Polymorphism, Encapsulation
     * 2. Can't be inherited
     * 3. It can inherit from others
     * 4. Can be instantiated
     * 5. Can have instance and static constructors
     * 6. Can have static and instance properties and fields
     * 7. Can be used for final implementations
     */
    internal sealed class SealedClass
    {
        public static string SealedClassStaticField = "SealedClassStaticField";
        public string SealedClassInstanceField = "SealedClassInstanceField";

        public SealedClass()
        {
            WriteLine("SEALED CLASS CONSTRUCTOR");
        }

        public void Method1()
        {
            WriteLine($"SEALED CLASS METHOD WITH STATIC FIELD:: {SealedClassStaticField} and INSTANCE FIELD:: {SealedClassInstanceField}");
        }
    }
}
