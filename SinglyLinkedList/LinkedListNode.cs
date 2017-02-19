using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class LinkedListNode
    {
        Object valor;
        LinkedListNode next;

        public object Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        internal LinkedListNode Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        public LinkedListNode ()
        {
            Valor = valor;
            Next = null;
        }
    }
}
