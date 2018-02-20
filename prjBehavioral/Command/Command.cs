using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Command
{
    /// <summary>
    /// Receiver
    /// </summary>
    public abstract class Command
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
