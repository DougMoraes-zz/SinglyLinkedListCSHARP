using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lista1 = new LinkedList();

            lista1.Add(3);
            lista1.Add("Rock");
            lista1.Add(3.4);
            lista1.Add('v');

            lista1.Contains('v');
            lista1.Contains(3);
            lista1.Contains(54);

            lista1.printAllNodes();



            Console.ReadKey();
        }
    }
}
