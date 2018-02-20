using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Command
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class Invoker
    {
        private List<Command> _commandsList = new List<Command>();
        private int _current = 0;

        public void Compute(Command command)
        {
            command.Execute();
            _commandsList.Add(command);
            _current++;
        }
        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commandsList[--_current];
                    _commandsList.Remove(command);
                    command.Undo();
                }
            }
        }
    }
}
