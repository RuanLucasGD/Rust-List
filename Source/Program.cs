using System;
using CSharp_Custom_List;

namespace CSharp_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> myList = new List<float>();

            myList.Add(2);
            myList.Add(3);
            myList.Add(1);
            myList.Add(7);
            myList.Add(3);
            //myList.ShowData();
            //Console.WriteLine(myList.Size);

            Console.WriteLine(myList.Get(2));

            Console.ReadKey();
        }
    }
}
