using CodingInterviewExamples.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingInterviewExamples.Questions
{
    //Write a function to detect a cycle in a linked list
    //The problem can be visualized by thinking of a Monopoly board game.  The squares the players land
    //on are like the nodes and the players are like the lag and lead pointers.  If you move the 
    //players at constant varying speeds (one player moves up one square and another player moves up
    //two squares) they will eventually land on the same square proving they are traveling in a circle.
    public class Question2: ICodingQuestion
    {

        public Question2()
        {

        }
        ////Call in Program.cs to test
        //LinkedListStack list = new LinkedListStack();
        //list.Push("pushed first");
        //list.Push("pushed second");
        //list.Push("pushed third");
        //Console.WriteLine(list.DetectCycle());
        //list.CreateCycle();
        //Console.WriteLine(list.DetectCycle());
        public void Run() {
            LinkedListStack list = new LinkedListStack();
            list.Push("pushed first");
            list.Push("pushed second");
            list.Push("pushed third");
            Console.WriteLine(list.DetectCycle());
            list.CreateCycle();
            Console.WriteLine(list.DetectCycle());

        }
    }

    partial class LinkedListStack
    {
       // private List<LinkListStackNode> _list = new List<LinkListStackNode>();
        private LinkListStackNode Current { get; set; }
        private LinkListStackNode Tail { get; set; }

        public void CreateCycle()
        {
            //We are setting creating a loop - Circular Linked List
            LinkListStackNode cur = Current;
            while(cur.Next != null)
            {
                
                cur = cur.Next;
            }
            
            cur.Next = Current;
            Current.Previous = cur;
        }
        public bool DetectCycle()
        {
            var node1 = Current;
            var node2 = Current.Next;

            while(node2.Next != null)
            {
                if(node1 == node2)
                {
                    return true;
                }
                //We are going to move over in the Linked List by One.
                node1 = node1.Next;
                //For the Second Node we will be moving them by Two.
                for(var i = 0; i<2; i++)
                {
                    if(node2.Next == null)
                    {
                        //This is not a cycle 
                        return false;
                    }
                    node2 = node2.Next;
                }
            }
            return false;
        }
        public void Push(string item)
        {
            var newItem = new LinkListStackNode(item);
            if(Current == null)
            {
                //The head    
                Current = newItem;

            }else if(Current.Next == null)
            {
                
                Current.Next = newItem;
                newItem.Previous = Current;
                Tail = newItem;
            }
            else
            {
                newItem.Previous = Tail;
                Tail.Next = newItem;
            }

            //_list.Add(newItem);
            Tail = newItem;
        }
    }

    partial class LinkListStackNode
    {
        private string _value;
        public LinkListStackNode Next { get; set; }
        public LinkListStackNode Previous { get; set; }

        public LinkListStackNode(string value)
        {
            _value = value;
        }
        
    }
}
