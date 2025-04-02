using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorTree
{
    public abstract class Task : Node
    {
        // Las tareas no tienen hijos, solo ejecutan acciones específicas.
    }
}

