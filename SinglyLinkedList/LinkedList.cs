using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class LinkedList
    {
        private LinkedListNode head = new LinkedListNode();

        internal LinkedListNode Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public LinkedList()
        {
            this.head = null;
        }

        public void Add(Object addValor)
        {
            LinkedListNode toAdd = new LinkedListNode();

            toAdd.Valor = addValor;
            toAdd.Next = head;

            head = toAdd;
        }

        public Boolean Contains(Object srchValor)
        {
            LinkedListNode atual = head;
            Object lkValor = atual.Valor;

            while(atual.Next != null)
            {
                if (lkValor == srchValor)
                {
                    Console.WriteLine("Achei!");

                    return true;
                }
                else
                {
                    atual = atual.Next;
                }
            }

            if (lkValor == srchValor)
            {
                Console.WriteLine("Achei no ultimo!");
                return true;
            }
            else
            {
                Console.WriteLine("Nada aqui!");
                return false;
            }
        }

        public void printAllNodes()
        {
            LinkedListNode atual = head;
            while (atual.Next != null)
            {
                Console.WriteLine(atual.Valor);
                atual = atual.Next;
            }

            Console.WriteLine(atual.Valor);
        }
    }
}
