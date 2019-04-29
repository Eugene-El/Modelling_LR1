using ModellingLib;
using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingApplication.Models
{
    public class ModelLog
    {
        public uint TransactId { get; set; }
        public TransactTypeEnum Type { get; set; }
        public double Time { get; set; }
        public EventTypeEnum Event { get; set; }

        public override string ToString()
        {
            return String.Format("Time: {0} - Transact #{1} ({2}) - {3}", Time, TransactId, Type, Event);
        }
    }
}
