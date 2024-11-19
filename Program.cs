using System.Collections.Generic;
using System.Collections;
namespace Domashna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1");
            LinkedList<int> nums = new LinkedList<int>();

            
            nums.AddFirst(5);
            nums.AddFirst(4);      
            nums.AddFirst(2);
            nums.AddFirst(1);

            Console.WriteLine(string.Join(" ", nums.Count));


            Console.WriteLine();
            Console.WriteLine("Exercise 2");
            LinkedList<string> names = new LinkedList<string>();
            names.AddFirst("Alice");
            names.AddLast("John");

           if (names.Contains("John"))
           {
                Console.WriteLine("true");
           }
            else
            {
                Console.WriteLine("false");
            }

      
            Console.WriteLine();
            Console.WriteLine("Exercise 3");
            LinkedListNode<int> node = nums.Find(2);

            if (node != null)
            {
                nums.AddAfter(node, 3);
            }
            Console.WriteLine("nums after insert");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}