using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib.Logs
{
    public enum EventTypeEnum
    {
        Born = 1,
        EnterQueue = 2,
        LeaveQueue = 3,
        EnterServer = 4,
        LeaveServer = 5,
        Death = 6
    }
}
