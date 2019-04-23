using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class ModelTime
    {
        public double Time { get; set; }

        public static bool operator == (ModelTime mt1, ModelTime mt2)
        {
            return mt1?.Time == mt2?.Time;
        }

        public static bool operator != (ModelTime mt1, ModelTime mt2)
        {
            return mt1?.Time != mt2?.Time;
        }

        public static bool operator <= (ModelTime mt1, ModelTime mt2)
        {
            return mt1?.Time <= mt2?.Time;
        }

        public static bool operator >= (ModelTime mt1, ModelTime mt2)
        {
            return mt1?.Time >= mt2?.Time;
        }

        public override string ToString()
        {
            return Time.ToString();
        }
    }
}
