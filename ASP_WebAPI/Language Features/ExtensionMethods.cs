namespace ASP_WebAPI.Language_Features
{
    internal static class ExtensionMethods
    {
        public static string FormatLine(this string data)
        {
            return $"@@ {data}";
        }
    }
}
