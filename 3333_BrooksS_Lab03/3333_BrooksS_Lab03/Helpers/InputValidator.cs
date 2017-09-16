using System;

namespace _3333_BrooksS_Lab03.Helpers
{
    public class InputValidator
    {
        public bool TryParseInt(string inputValue, out int value)
        {
            return int.TryParse(inputValue, out value);
        }

        public bool ParseInt(string inputValue, out int value, out string error)
        {
            try
            {
                value = int.Parse(inputValue);
                error = "";
                return true;
            }
            catch (Exception ez)
            {
                value = -1;
                error = ez.ToString();
                return false;
            }
        }
    }
}
