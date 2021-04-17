using System;
using CSharp_Custom_List;

namespace CSharp_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<float> myList = new List<float>();

            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);

            myList.ShowData();
            myList.Remove(1);
            Console.WriteLine("##########################");
            myList.ShowData();

            myList.Add(3);
            myList.Add(3);
            myList.Add(3);

            Console.WriteLine("##########################");
            myList.ShowData();

            Console.ReadKey();
        }
    }
}
