using System;
using System.Collections.Generic;

namespace TumakovPlus
{
    public class QueueManager
    {
        private Stack<Resident> residentsQueue = new Stack<Resident>();

        public void AddResident(Resident resident)
        {
            residentsQueue.Push(resident);
        }

        public void ProcessQueue()
        {
            while (residentsQueue.Count > 0)
            {
                Resident resident = residentsQueue.Pop();
                int window = resident.ChooseWindow();
                Console.WriteLine($"{resident.Name} направляется в окно {window}.");
            }
        }
    }
}
