using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class Drain
    {
        private ModelTime _time;
        public List<Transact> DrainedTransacts { get; set; }

        public Drain(ref ModelTime time)
        {
            _time = time;
            DrainedTransacts = new List<Transact>();
        }

        public void DrainTransact(Transact transact)
        {
            transact.AddLog(new TransactLog(_time, EventTypeEnum.Death));
            DrainedTransacts.Add(transact);
        }
    }
}
