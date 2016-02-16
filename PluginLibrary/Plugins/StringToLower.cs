namespace PluginLibrary.Plugins
{
    public class StringToLower : IPlugin<string>
    {
        /// <summary>
        /// Returns the string converted to lowercase
        /// </summary>
        /// <param name="param">String to convert</param>
        /// <returns>String converted to lowercase</returns>
        public string Modify(string param)
        {
            return param.ToLower();
        }
    }
}