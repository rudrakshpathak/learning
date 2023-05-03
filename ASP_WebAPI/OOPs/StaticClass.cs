namespace ASP_WebAPI.OOPs
{
    /*
     * 1. OOP Support: Encapsulation, Polymorphism
     * 2. Can't be inherited
     * 3. Can't be instantiated
     * 4. Storage is on heap
     * 5. Static members have global space, means change in one field will impact all
     * 6. Can have static constructor
     * 7. Can't have instance constructor
     * 8. Can only have static members, fields, events, properties
     * 9. Can't implement interfaces
     * 10. Use case is for utility methods
     */
    internal static class StaticClass
    {
        private static string _applicationName = "";
        private static string _defaultAppName = "Deafult App Name";

        public static string DefaultAppName
        {
            get 
            {
                return _defaultAppName;
            }
        }

        static StaticClass()
        {
            _applicationName = "ASP_WebAPI";
        }

        public static string GetApplicationName()
        {
            return $"APPLICATION NAME:: {_applicationName}";
        }

        public static string GetApplicationName(string differentApplicationName)
        {
            return $"APPLICATION NAME:: {differentApplicationName}";
        }
    }
}
