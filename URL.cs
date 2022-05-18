using System;

namespace URL
{
    public class URLParts
    {
        public static void Main()
        {
            Uri baseUri = new Uri("https://www.apple.com/iphone");
            Uri myUri = new Uri(baseUri, "shownew.htm?date=today");

            Console.WriteLine(myUri.Host);

        }
    }
}

