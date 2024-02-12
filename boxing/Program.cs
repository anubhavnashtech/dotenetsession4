using System;
using System.Collections;

namespace boxing
{
    class Program
        {
            static void Main(string[] args)
            {
                
                var list  = new ArrayList();

                list.Add(1);
                list.Add("Doe");
                list.Add(DateTime.Today);

                //var number = (int)list[1];

                var anotherList = new List<int>();

                anotherList.Add(1);
            }
        }
}