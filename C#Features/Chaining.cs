namespace CSharpFeatures
{
    internal class Chaining
    {
        public List<string> list = new List<string>();

        public Chaining AddName()
        {
            list.Add("Rudra");
            return this;
        }

        public Chaining AddAge()
        {
            list.Add("22");
            return this;
        }
    }
}
