using System.Collections.Generic;

namespace WorkFlowEngine
{
    partial class Program
    {
        public partial class WorkFlowEngine
        {
            public  IActivity _activity { get; private set; }

            public WorkFlowEngine()
            {

            }
            public WorkFlowEngine(IActivity activity)
            {
                _activity = activity;
            }

            // Takes an workflow, and iterates over each activity and runs it.
            public void Run(IActivity activity)
            {
                activity.Execute();
               
            }
        }
    }
}
