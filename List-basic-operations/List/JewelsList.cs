using System;
using System.Collections.Generic;
using System.Text;

namespace List_basic_operations.List
{
    class JewelsList
    {
        public JewelsNode Head;

        public void Add(Jewels jewelstoAdd)
        {
            JewelsNode newJewelsNode = new JewelsNode();
            newJewelsNode.Jewels = jewelstoAdd;
            if (Head == null)
            {
                Head = newJewelsNode;
            }
            else
            {
                JewelsNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }

                last.Next = newJewelsNode;
            }
        }

        public void InsertP(Jewels jewelsToInsert, int pos)
        {
            JewelsNode newJewelsNode = new JewelsNode();
            newJewelsNode.Jewels = jewelsToInsert;
            newJewelsNode.Next = null;
            if (Head == null)
            {
                Head = newJewelsNode;
            }
            else
            {
                JewelsNode last;
                last = Head;
                if (pos == 1)
                {
                    Head = newJewelsNode;
                    newJewelsNode.Next = last;
                }
                    
                   else
                {
                    for (int i=1; i<pos-1; i++)
                    {
                        last = last.Next;
                        if (last.Next == null) break;
                    }

                    JewelsNode lastnext;
                    lastnext = last.Next;
                    last.Next = newJewelsNode;
                    newJewelsNode.Next = lastnext;
                }
            }
        }

        public void Print()
        { 
            JewelsNode tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"Sale Day: {tmp.Jewels.SaleDay} - Branch Office: {tmp.Jewels.Branchoffice}");
                tmp = tmp.Next;
            }
        }
    }
}
