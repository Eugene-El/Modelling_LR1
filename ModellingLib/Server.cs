using GenerationLib;
using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class Server
    {
        private ModelTime _time;
        private AbstractGenerator _aTypeGenerator;
        private AbstractGenerator _bTypeGenerator;
        private Transact _currentTransact;

        public ModelTime NextReleaseTime { get; private set; }
        public bool IsNextReleaseTime { get { return NextReleaseTime != null; } }
        public bool IsFree { get; private set; }

        public Server(ref ModelTime time,
            AbstractGenerator aTypeGenerator,
            AbstractGenerator bTypeGenerator)
        {
            _time = time;
            _aTypeGenerator = aTypeGenerator;
            _bTypeGenerator = bTypeGenerator;
            IsFree = true;
        }

        public void Enter(Transact transact)
        {
            transact.AddLog(new TransactLog(_time, EventTypeEnum.EnterServer));
            IsFree = false;
            _currentTransact = transact;
            NextReleaseTime = new ModelTime()
            {
                Time = _time.Time + (_currentTransact.Type == TransactTypeEnum.Atype ? _aTypeGenerator.Next() : _bTypeGenerator.Next())
            };
        }

        public Transact Leave()
        {
            _currentTransact.AddLog(new TransactLog(_time, EventTypeEnum.LeaveServer));
            IsFree = true;
            return _currentTransact;
        }
    }
}
