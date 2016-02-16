using System;

namespace PluginLibrary
{
    /// <summary>
    /// Helper class for work with plugins
    /// </summary>
    /// <typeparam name="T">Type of plugin</typeparam>
    public class PluginHelper<T>
    {
        public IPlugin<T> Plugin { get; set; }
        public T Data { get; set; }

        public PluginHelper(IPlugin<T> plugin, T data)
        {
            Plugin = plugin;
            Data = data;
        }

        /// <summary>
        /// Print to the console the result of Plugin Modify Method
        /// </summary>
        public void PrintToConsole()
        {
            var modifiedData = Plugin.Modify(Data);
            Console.WriteLine("Result: "+ modifiedData);
        }
    }
}