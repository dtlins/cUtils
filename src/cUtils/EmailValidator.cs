using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CUtils
{
    /// <summary>
    /// Provides Email Validation methods.
    /// </summary>
    public static class EmailValidator
    {
        /// <summary>
        /// Validates email according to the regex @ https://stackoverflow.com/a/16168103
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool IsValid(string email)
        {
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
