using GenerationLib;
using ModellingLib.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class Source
    {
        private ModelTime _time;
        private AbstractGenerator _aTypeGenerator;
        private AbstractGenerator _bTypeGenerator;
        private uint idCounter = 0;

        public ModelTime NextAGenerationTime { get; private set; }
        public ModelTime NextBGenerationTime { get; private set; }


        public Source(ref ModelTime time,
            AbstractGenerator aTypeGenerator,
            AbstractGenerator bTypeGenerator)
        {
            _time = time;
            _aTypeGenerator = aTypeGenerator;
            _bTypeGenerator = bTypeGenerator;

            NextAGenerationTime = new ModelTime()
            {
                Time = _time.Time + _aTypeGenerator.Next()
            };
            NextBGenerationTime = new ModelTime()
            {
                Time = _time.Time + _bTypeGenerator.Next()
            };
        }

        public Transact Get()
        {
            Transact transact = null;
            if (NextAGenerationTime == _time)
            {
                NextAGenerationTime = new ModelTime()
                {
                    Time = _time.Time + _aTypeGenerator.Next()
                };
                transact = new Transact(++idCounter, TransactTypeEnum.Atype);
            }
            if (NextBGenerationTime == _time)
            {
                NextBGenerationTime = new ModelTime()
                {
                    Time = _time.Time + _bTypeGenerator.Next()
                };
                transact = new Transact(++idCounter, TransactTypeEnum.Btype);
            }

            transact?.AddLog(new TransactLog(_time, EventTypeEnum.Born));
            return transact;
        }

    }
}
