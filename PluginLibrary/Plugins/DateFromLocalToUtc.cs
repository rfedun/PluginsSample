using System;

namespace PluginLibrary.Plugins
{
    public class DateFromLocalToUtc : IPlugin<DateTime>
    {
        /// <summary>
        /// Returns time converted to universal time
        /// </summary>
        /// <param name="param">Time to convert</param>
        /// <returns>Time converted to universal time</returns>
        public DateTime Modify(DateTime param)
        {
            return param.ToUniversalTime();
        }
    }
}
