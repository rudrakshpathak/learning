using Org.BouncyCastle.Utilities;

namespace ASP_WebAPI.Language_Features
{
    public class BoxAndUnbox
    {
        public int number;

        public object BoxValue()
        {
            number = 2;
            object boxed = number;

            return boxed;
        }

        public int UnboxValue()
        {
            return (int)number;
        }
    }
}
