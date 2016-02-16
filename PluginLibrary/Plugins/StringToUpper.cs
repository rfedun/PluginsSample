namespace PluginLibrary.Plugins
{
    public class StringToUpper : IPlugin<string>
    {
        /// <summary>
        /// Returns the string converted to uppercase
        /// </summary>
        /// <param name="param">String to convert</param>
        /// <returns>String converted to lowercase</returns>
        public string Modify(string param)
        {
            return param.ToUpper();
        }
    }
}