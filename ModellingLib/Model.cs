using GenerationLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellingLib
{
    public class Model
    {
        private ModelTime _time;

        public ModelTime Time { get { return _time; } }
        public ModelTime MaxTime { get; private set; }

        public Source Source { get; private set; }
        public Drain Drain { get; private set; }

        public Queue Queue { get; private set; }
        public Server Server { get; private set; }

        public Model(
            AbstractGenerator sourceAGenerator,
            AbstractGenerator sourceBGenerator,
            AbstractGenerator serverAGenerator,
            AbstractGenerator serverBGenerator,
            ModelTime maxTime)
        {
            _time = new ModelTime();
            MaxTime = maxTime;

            Source = new Source(ref _time, sourceAGenerator, sourceBGenerator);
            Drain = new Drain(ref _time);

            Queue = new Queue(ref _time);
            Server = new Server(ref _time, serverAGenerator, serverBGenerator);
        }

        public void Run()
        {
            while (Time <= MaxTime)
            {
                var min = Min(Source.NextAGenerationTime,
                    Source.NextBGenerationTime,
                    Server.IsNextReleaseTime && !Server.IsFree ? Server.NextReleaseTime : MaxTime);

                if (min == MaxTime)
                    break;
                Time.Time = min.Time;

                if (Server.IsNextReleaseTime && !Server.IsFree && min == Server.NextReleaseTime)
                {
                    var tran = Server.Leave();
                    Drain.DrainTransact(tran);

                    if (!Queue.Empty)
                        Server.Enter(Queue.Leave());
                    
                }
                else
                {
                    var tran = Source.Get();
                    Queue.Enter(tran);

                    if (Server.IsFree)
                        Server.Enter(Queue.Leave());
                }

            }
        }

        private ModelTime Min(ModelTime mt1, ModelTime mt2, ModelTime mt3)
        {
            return new ModelTime() { Time = Math.Min(Math.Min(mt1.Time, mt2.Time), mt3.Time) };
        }
    }
}
