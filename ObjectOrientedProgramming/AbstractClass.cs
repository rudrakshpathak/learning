using static System.Console;

namespace ObjectOrientedProgramming
{
    /*
     * 1. OOP Support: Inheritance, Polymorphism, Abstraction, Encapsulation
     * 2. Instance cannot be created
     * 3. Can have abstract and non-abstract methods
     * 4. It is not mandatory to have abstract methods
     * 5. Can have fields and properties
     * 6. Can have static constructor for static properties
     * 7. Class cannot be sealed since it is supposed to be inherited
     * 8. Can have instance constructor but cannot be invoked directly
     * 9. Have to write the override keyword to implement the abstract method
     * 10. If a parameterized constructor is called explicitly, the default constructor won't be called
     */
    internal abstract class AbstractClass
    {
        public static string? staticMember = default;

        /// <summary>
        /// Static constructor for initializing static properties
        /// </summary>
        static AbstractClass()
        {
            staticMember = "StaticMember";
        }

        /// <summary>
        /// Instance constructor
        /// </summary>
        public AbstractClass()
        {
            WriteLine($"Abstract class constructor having static value:: {staticMember}");
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="number"></param>
        public AbstractClass(int number)
        {
            WriteLine($"Abstract class parameterized constructor:: {number}");
        }

        /// <summary>
        /// Sample abstract method, must be implemented by the derived class
        /// </summary>
        public abstract void Method1();
    }
}
