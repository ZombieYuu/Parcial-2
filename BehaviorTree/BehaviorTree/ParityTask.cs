using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorTree
{
    public class ParityTask : Task
    {
        private int number;

        public ParityTask(int number)
        {
            this.number = number;
        }

        public override bool Execute()
        {
            return number % 2 == 0;
        }
    }
}

