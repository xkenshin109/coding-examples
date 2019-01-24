using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    public class Question3 : ICodingQuestion
    {
        //we would be adding node from second list to first list
        //If second node data id more than first one then exchange it
        public void Run()
        {
            LinkedList l1 = new LinkedList();
            l1.Push(2);
            l1.Push(4);
            l1.Push(3);
            l1.Push(2);
            l1.Push(1);

            LinkedList l2 = new LinkedList();
            l2.Push(7);
            l2.Push(2);
            l2.Push(3);
            l2.Push(5);

            l1.Merge(l2);
        }
    }

    partial class LinkedList
    {
        public LinkedList()
        {
            Head = new LinkedListNode();
        }
        public LinkedListNode Head { get; set; }
        
        public void Push(int value)
        {
            var newItem = new LinkedListNode(value);
            if (Head == null)
            {
                Head = newItem;
                return;
            }
            Head.Add(value);
            while(Head.Previous != null)
            {
                //We reset the Head if it changes
                Head = Head.Previous;
            }
        }
        public void Merge(LinkedList list2)
        {
            var cur = list2.Head;
            
            while(cur.Next != null || cur._value != null)
            {
                var val = cur._value;
                cur = cur.Next;
                Head.Add(val);
                if(cur == null)
                {
                    //we done
                    break;
                }
            }
        }
    }

    partial class LinkedListNode
    {
        public int? _value;
        public LinkedListNode Next { get; set; }
        public LinkedListNode Previous { get; set; }
        public LinkedListNode(int? val)
        {
            _value = val;
            Next = new LinkedListNode();
            Previous = new LinkedListNode();
        }
        public LinkedListNode() {

        }
        public void Add(int? value)
        {
            
            if(_value == null)
            {
                _value = value;
                return;
            }else if(_value > value)
            {
                var newItem = new LinkedListNode(value)
                {
                    Previous = Previous,
                    Next = this
                };
                if(Previous != null)
                {
                    Previous.Next = newItem;
                }
                Previous = newItem;
                return;
                //We place the new Node before this one
            }
            if (Next == null) {
                Next = new LinkedListNode
                {
                    Previous = this
                };
            };
            Next.Add(value);
        }
    }
}
