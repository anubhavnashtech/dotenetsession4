using System;

namespace inheritance
{
    public class PresentationObject
    {
        public int Width {get; set;}
        public int Height {get; set;}

        public void Copy(int a)
        {
            System.Console.WriteLine("Object is copied");
        }

        public void Duplicate()
        {
            System.Console.WriteLine("Object is duplicated");
        }
    }

    public class Text : PresentationObject
    {
        public int FontSize {get; set;}
        public int FontWidth {get; set;}

        public void AddHyperlink(string url)
        {
            System.Console.WriteLine("Url is added: {0}", url);
        }
    }

    public class Program
        {
            static void Main(string[] args)
            {
                
                var text  = new Text();
            }
        }
}
