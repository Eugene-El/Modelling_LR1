using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib.Logs
{
    public class TransactLog
    {
        public ModelTime Time { get; private set; }
        public EventTypeEnum Event { get; private set; }

        public TransactLog(ModelTime time, EventTypeEnum type)
        {
            Time = new ModelTime() { Time = time.Time };
            Event = type;
        }

        public override string ToString()
        {
            return String.Format("Time: {0} - {1}", Time, Event);
        }
    }
}
