using ModellingLib;
using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingApplication.Extensions
{
    public static class TransactExtension
    {
        private static double GetDiference(this Transact transact, EventTypeEnum first, EventTypeEnum second)
        {
            var journal = transact.GetJournal();
            return journal.Find(l => l.Event == second).Time.Time
                - journal.Find(l => l.Event == first).Time.Time;
        }

        public static double GetLifeTime(this Transact transact)
        {
            return transact.GetDiference(EventTypeEnum.Born, EventTypeEnum.Death);
        }

        public static double GetTimeInQueue(this Transact transact)
        {
            return transact.GetDiference(EventTypeEnum.EnterQueue, EventTypeEnum.LeaveQueue);
        }

        public static double GetTimeInServer(this Transact transact)
        {
            return transact.GetDiference(EventTypeEnum.EnterServer, EventTypeEnum.LeaveServer);
        }
    }
}
