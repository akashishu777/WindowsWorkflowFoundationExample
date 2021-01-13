using System;
using System.Activities;
using System.Activities.Statements;
using System.Linq;

namespace DemoWorkflowConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequential Execution Started");
            Activity Sequential = new Workflow1();
            WorkflowInvoker.Invoke(Sequential);

            Console.WriteLine("\n\nFlowChart Execution Started");
            Activity FlowChart = new FlowChartWorkFlow();
            WorkflowInvoker.Invoke(FlowChart);

            Console.WriteLine("\n\nStateMachine Execution Started");
            Activity StateMachine = new StateMachineWorkFlow();
            WorkflowInvoker.Invoke(StateMachine);
            Console.ReadLine();
        }
    }
}
