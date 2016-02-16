using System;
using PluginLibrary;
using PluginLibrary.Plugins;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Plugins examples ***");

            Console.WriteLine("***String to upper example***");
            var text = "Some Text";
            Console.WriteLine("Input text: " + text);
            new PluginHelper<string>(new StringToUpper(), text).PrintToConsole();
            Console.WriteLine("");

            Console.WriteLine("***Adding point to the end of the string***");
            var text1 = "Some Text1";
            Console.WriteLine("Input text: " + text1);
            new PluginHelper<string>(new StringAddPoint(), text1).PrintToConsole();
            Console.WriteLine("");

            Console.WriteLine("***Use plugin collection to apply multiple string plugins to text***");
            var text2 = "Some Text2";
            Console.WriteLine("Input text: " + text2);
            var pc = new PluginCollection<string>();
            pc.Plugins.Add(new StringAddPoint());
            pc.Plugins.Add(new StringToUpper());
            new PluginHelper<string>(pc, text2).PrintToConsole();
            Console.WriteLine("");

            Console.WriteLine("***Multiply value by 2 and return absolute value (Pluginable plugin example)***");
            var val = -29;
            Console.WriteLine("Input value: " + val );
            new PluginHelper<int>(new NumberMultiplyBy2WithPlugin(new NumberAbsoluteValue()), val).PrintToConsole();
            Console.WriteLine("");
            
            Console.ReadKey();
        }
    }
}
