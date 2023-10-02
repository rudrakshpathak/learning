using System.Reflection;
using static System.Console;
namespace ObjectOrientedProgramming
{
    /*
    * 1. OOP Support: Inheritance, Polymorphism, Encapsulation
    * 2. Can have generic parameters for types which can later be instantiated with concrete type
    * 3. Can provide generic functionality which can be implemented with differnet types
    * 4. Can have static and instance constructor
    * 5. Provides compile time checking for types passed
    * 6. Generic class provides reusability
    */
    internal class GenericClass<T>
    {
        public GenericClass(T type)
        {
            WriteLine("GERNERIC CLASS CONSTRUCTOR");
        }

        public void GetDetailsOfType(T type)
        {
            TypeInfo typeInfo = typeof(T).GetTypeInfo();
            WriteLine(typeInfo.Name);
        }
    }
}
