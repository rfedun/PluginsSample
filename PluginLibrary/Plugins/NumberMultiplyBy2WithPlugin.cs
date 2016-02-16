namespace PluginLibrary.Plugins
{
    public class NumberMultiplyBy2WithPlugin : IPlugin<int>
    {
        public IPlugin<int> Plugin { get; set; }

        public NumberMultiplyBy2WithPlugin(IPlugin<int> plugin)
        {
            Plugin = plugin;
        }

        /// <summary>
        /// Returns number that modified by the plugin after multiplying it by 2
        /// </summary>
        /// <param name="param">Number to modify</param>
        /// <returns>Modified number</returns>
        public int Modify(int param)
        {
            return  Plugin.Modify(param*2);
        }
    }
}