using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class Transact
    {
        private List<TransactLog> _journal = new List<TransactLog>();

        public uint Id { get; private set; }
        public TransactTypeEnum Type { get; private set; }

        public Transact(uint id, TransactTypeEnum type)
        {
            Id = id;
            Type = type;
        }

        public void AddLog(TransactLog log)
        {
            _journal.Add(log);
        }

        public List<TransactLog> GetJournal()
        {
            return new List<TransactLog>(_journal);
        }

        public override string ToString()
        {
            return String.Format("Transact #{0} - {1}", Id, Type);
        }

        public string ToStoryString()
        {
            string str = "Transact - id: " + Id + ", Story: \n";
            foreach (TransactLog log in _journal)
                str += "Time: " + log.Time + " " + log.Event.ToString() + "\n";
            return str;
        }

    }
}
