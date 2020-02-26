using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConctereBuilder();
            builder.AddPart("bread");
            builder.AddPart("milk");
            builder.AddPart("salt");
            Console.WriteLine(builder.GetProduct());
        }
    }
}
