namespace WorkFlowEngine
{
    partial class Program
    {
        public partial class WorkFlowEngine
        {
            public class SendEmail : IActivity
            {
                public void Execute()
                {
                    System.Console.WriteLine("Sending E-mail");
                }
            }
        }
    }
}
