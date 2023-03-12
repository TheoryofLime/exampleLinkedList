using System;

namespace exampleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> newList = new LinkedList<string>();
            // add items
            newList.AddLast("A");
            newList.AddLast("B");
            newList.AddLast("C");
            newList.AddLast("D");
            newList.AddLast("E");
            // display that first node
            string[] listArray = new string[newList.Count];
            newList.CopyTo(listArray, 0);

            Console.WriteLine(listArray[0]);
            // now the last
            Console.WriteLine(listArray[listArray.Length-1]);
            // add another item in the middle
            newList.AddAfter(newList.Find("B"), "F");
            // kill a node
            newList.RemoveLast();
            // count those NODES!
            Console.WriteLine(newList.Count);
            // display those NODES!
            foreach (string s in newList) Console.WriteLine(s);
        }
    }
}
