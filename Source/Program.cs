using System;
using CSharp_Custom_List;

namespace CSharp_Custom_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();

            myList.Add(5);
            myList.Add(3);
            myList.Add(1);
            myList.Add(7);
            myList.Add(3);
            myList.ShowData();

            Console.WriteLine(myList.Size);

            Console.ReadKey();
        }
    }
}
