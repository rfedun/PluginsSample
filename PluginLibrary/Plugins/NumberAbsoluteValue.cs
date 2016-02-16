using System;

namespace PluginLibrary.Plugins
{
    public class NumberAbsoluteValue : IPlugin<int>
    {
        /// <summary>
        /// Returns absolute meaning of the number
        /// </summary>
        /// <param name="param">Number to modify</param>
        /// <returns>Absolute meaning of the number</returns>
        public int Modify(int param)
        {
            return Math.Abs(param);
        }
    }
}