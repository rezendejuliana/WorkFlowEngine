namespace WorkFlowEngine
{
    partial class Program
    {
        public partial class WorkFlowEngine
        {
            public class Video : IActivity
            {
                public void Execute()
                {
                    System.Console.WriteLine("Uploading a Video");
                }

            }
        }
    }
}
