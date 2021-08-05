using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new RobotBuilder();
            builder.SetName("C3PO");
            builder.SetPrimaryFunction("Protocol droid");

            builder.AddPart("One head");
            builder.AddPart("Body");
            builder.AddPart("Two arms");
            builder.AddPart("Two legs");

            var c3po = builder.Build();
      
            builder.Reset();
            builder.SetName("R2D2");
            builder.SetPrimaryFunction("Astromechanical");

            builder.AddPart("One head");
            builder.AddPart("Cilinder body");
            builder.AddPart("Whells");

            var r2d2 = builder.Build();

            Console.WriteLine("--------- First robot -------------");
            c3po.Diagnostics();
            Console.WriteLine("\n\n--------- Second robot -------------");
            r2d2.Diagnostics();

            Console.ReadLine();
        }
    }
}
