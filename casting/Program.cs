using System;
using System.Collections;

namespace casting
{
    public class Shape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public void Draw()
        {

        }

    }

    public class Text : Shape
    {
        public int FontName { get; set; }

        public int FontSize { get; set; }
    }
    
   public class Program
        {
            static void Main(string[] args)
            {

                //  demo for UpCasting
              //   DemoUpcasting();

                // Demo for down casting

               DemoDowncastig();
            }

            public static void DemoUpcasting()
            {
                                
                Text text = new Text();

                Shape shape = text;

                text.Width = 200;

                shape.Width = 100;

                System.Console.WriteLine("Width is {0}", text.Width);


                var arraylist = new ArrayList();

                arraylist.Add(1);

                arraylist.Add("abc");

                arraylist.Add(new Text());

                var number = arraylist[1];


                var anotherList  = new List<int>();
            }

            public static void DemoDowncastig()
            {

                Shape  shape  = new Text();

                System.Console.WriteLine(shape.GetType());

                //shape.

                Text text = (Text) shape;

            }
        }
}