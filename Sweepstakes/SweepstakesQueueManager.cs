using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> queue;

        public SweepstakesQueueManager()
        {

        }
        
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}

//Create a SweepstakesQueueManager class that uses the Queue data structure as an underlying 

//Queue is an abstract data type that contains elements in linear order
//Abstract data type is a model of a certain kind of data structure (stack, queue) where behavior
// is defined rather than implemented, specifically in terms of operations (push, pop) (enqueue, dequeue)
//Stack and Queue operations are allowed only at the ends, not in the middle

// (FIFO) = First In, First Out   (like people at DMV)
// Insertion (enqueue) is performed on one end (rear) of the queue while 
// Deletion (dequeue) is performed on the other end (front).