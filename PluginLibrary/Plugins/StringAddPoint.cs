namespace PluginLibrary.Plugins
{
    public class StringAddPoint : IPlugin<string>
    {
        /// <summary>
        /// Returns the string that ends with point
        /// </summary>
        /// <param name="param">String to modify</param>
        /// <returns>String that ends with point</returns>
        public string Modify(string param)
        {
            return param.EndsWith(".") ? param : param + ".";
        }
    }
}