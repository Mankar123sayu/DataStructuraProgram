using DataStructureProblem;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
           // LinkedList Data = new LinkedList();
            //Data.Add(56);
            //Data.Add(30);
            //Data.Add(70);
           //Data.Display();

            // Data.AddInReverseOrder(56);
            // Data.AddInReverseOrder(30);
            // Data.AddInReverseOrder(70);
            //Data.Display();

             //Data.InsertAtParticularPosition(1, 30);
             //Data.Display();

            // Data.RemoveFirstNode();
             //Data.Display();

            //Data.RemoveLastNode();
           // Data.Display();

            //Data.Search(56);
            //Data.Display();

           // int position = Data.Search(30);
            //Data.InsertAtParticularPosition(position + 1, 40);
            //Data.Display();
            //Console.WriteLine();
            //int searchDelete = Data.Search(40);
            //Data.DeleteNodeAtParticularPosition(searchDelete);
           // Data.Display();

            //Data.Size();
            //Data.Display();

           // LinkedListStack stack = new LinkedListStack();
            //stack.Push(70);
            //stack.Push(30);
           // stack.Push(56);
           // stack.Display();

            //stack.Peak();
            //stack.Pop();
            //stack.Display();

             LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();

            queue.Dequeue();
            queue.Display();
        }
    }
}