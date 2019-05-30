using System.Text.RegularExpressions;

namespace Task13
{
    class Validation
    {
        public static bool ValidateEmail(string email)
        {
            Match match = Regex.Match(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ValidateURL(string URL)
        {
            Match match = Regex.Match(URL, @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$", RegexOptions.IgnoreCase);
            return match.Success;
        }

        public static bool ValidatFilePath(string path)
        {
            Match match = Regex.Match(path, @"^(?:[\w]\:|\\)(\\[a-z_\-\s0-9\.]+)+\.(txt|gif|pdf|doc|docx|xls|xlsx)$", RegexOptions.IgnoreCase);
            return match.Success;
        }
    }
}
