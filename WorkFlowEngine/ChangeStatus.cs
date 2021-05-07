namespace WorkFlowEngine
{
    partial class Program
    {
        public partial class WorkFlowEngine
        {
            public class ChangeStatus : IActivity
            {
                public void Execute()
                {
                    System.Console.WriteLine("Processing");
                }
            }
        }
    }
}
