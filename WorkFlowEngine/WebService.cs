namespace WorkFlowEngine
{
    partial class Program
    {
        public partial class WorkFlowEngine
        {
            public class WebService : IActivity
            {
                public void Execute()
                {
                    System.Console.WriteLine("Calling Web Service - Video Ready to Encode");
                }
            }
        }
    }
}
