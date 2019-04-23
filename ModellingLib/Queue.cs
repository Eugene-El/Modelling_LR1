using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModellingLib
{
    public class Queue
    {
        private ModelTime _time;
        private Stack<Transact> _queue = new Stack<Transact>();

        public bool Empty { get { return _queue.Count == 0; } }

        public Queue(ref ModelTime time)
        {
            _time = time;
        }

        public void Enter(Transact transact)
        {
            transact.AddLog(new TransactLog(_time, EventTypeEnum.EnterQueue));
            _queue.Push(transact);
        }

        public Transact Leave()
        {
            Transact onExit = _queue.Pop();
            onExit.AddLog(new TransactLog(_time, EventTypeEnum.LeaveQueue));
            return onExit;
        }
    }
}
