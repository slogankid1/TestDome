using System;
using System.Collections.Generic;

namespace TrainComposition
{
    public class TrainComposition
    {
        public LinkedList<int> Train = new LinkedList<int>();

        public void AttachWagonFromLeft(int wagonId)
        {
            Train.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            Train.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            int leftmostWagonId = Train.First.Value;
            Train.RemoveFirst();
            return leftmostWagonId;
        }

        public int DetachWagonFromRight()
        {
            int rightmostWagonId = Train.Last.Value;
            Train.RemoveLast();
            return rightmostWagonId;
        }

        public static void Main(string[] args)
        {
            TrainComposition tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            Console.WriteLine(tree.DetachWagonFromRight()); // 7 
            Console.WriteLine(tree.DetachWagonFromLeft()); // 13

            Console.ReadKey();
        }
    }
}
