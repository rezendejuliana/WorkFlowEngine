using System;
using System.Collections.Generic;
using static WorkFlowEngine.Program.WorkFlowEngine;

namespace WorkFlowEngine
{
    partial class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> activities = new List<IActivity>();

            Video video = new Video();
            WebService webService = new WebService();
            SendEmail sendEmail = new SendEmail();
            ChangeStatus changeStatus = new ChangeStatus();

            WorkFlowEngine workFlowEngine = new WorkFlowEngine();

            activities.Add(video);
            activities.Add(webService);
            activities.Add(sendEmail);
            activities.Add(changeStatus);

            foreach (IActivity act in activities)
            {
                workFlowEngine.Run(act);
            }

        }
    }
}
