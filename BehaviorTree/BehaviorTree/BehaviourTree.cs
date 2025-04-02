using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BehaviorTree
{
    public class BehaviourTree
    {
        public Root Root { get; private set; }

        public BehaviourTree()
        {
            Root = new Root();
        }

        public bool Execute()
        {
            return Root.Execute();
        }
    }

    public class Root : Node
    {
        private Node child;

        public void SetChild(Node node)
        {
            if (node is Root)
            {
                throw new InvalidOperationException("Root cannot have another Root as a child.");
            }
            child = node;
        }

        public override bool Execute()
        {
            return child?.Execute() ?? false;
        }
    }
}

