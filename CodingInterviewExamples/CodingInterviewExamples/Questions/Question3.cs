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
        private List<int?> _result { get; set; }
        public string Result => string.Join(",",_result);
        private LinkedList _list1, _list2;
        public Question3(int[] list1, int[] list2)
        {
            _result = new List<int?>();
            _list1 = new LinkedList();
            _list2 = new LinkedList();
            foreach(var item in list1)
            {
                _list1.Push(item);
            }
            foreach(var item in list2)
            {
                _list2.Push(item);
            }
        }
        //we would be adding node from second list to first list
        //If second node data id more than first one then exchange it
        public void Run()
        {
            
            _list1.Merge(_list2);
            var cur = _list1.Head;
            _result.Add(cur._value);
            while(cur.Next != null)
            {
                cur = cur.Next;

                if(cur != null)
                {
                    _result.Add(cur._value);
                }
            }

        }
    }

    public partial class LinkedList
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

    public partial class LinkedListNode
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
