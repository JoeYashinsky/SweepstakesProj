using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> stack;

        public SweepstakesStackManager()
        {

        }
        
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}

//Create a SweepstakesStackManager class that uses the Stack data structure as an underlying structure

//Queue is an abstract data type that contains elements in linear order
//Abstract data type is a model of a certain kind of data structure (stack, queue) where behavior
// is defined rather than implemented, specifically in terms of operations (push, pop) (enqueue, dequeue)
//Stack and Queue operations are allowed only at the ends, not in the middle

// (LIFO) = Last In, First Out  (like a stack of papers)
// Collection of elements where we can insert (PUSH) or delete (POP) elements only at TOP of stack
// Cannot push an element onto stack if stack is full (overflow state). 
// Also cannot pop an element from empty stack (underflow state).

