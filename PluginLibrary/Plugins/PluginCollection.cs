using System.Collections.Generic;

namespace PluginLibrary.Plugins
{
    /// <summary>
    /// Class to work with plugin collection
    /// </summary>
    /// <typeparam name="T">Type of the plugins in collection</typeparam>
    public class PluginCollection<T> : IPlugin<T>
    {
        public List<IPlugin<T>> Plugins { get; set; } = new List<IPlugin<T>>();
        
        /// <summary>
        /// Apply all plugins from Plugins collection to the object and returns this object
        /// </summary>
        /// <param name="param">Object to modify</param>
        /// <returns>Modified object</returns>
        public T Modify(T param)
        {
            foreach (var plugin in Plugins)
            {
                param = plugin.Modify(param);
            }
            return param;
        }
    }
}