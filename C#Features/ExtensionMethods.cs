namespace CSharpFeatures
{
    internal static class ExtensionMethods
    {
        public static string FormatLine(this string data)
        {
            return $"@@ {data}";
        }
    }
}
