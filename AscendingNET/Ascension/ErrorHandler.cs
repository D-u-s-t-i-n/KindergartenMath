using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ascension
{
    internal class ErrorHandler
    {
        /// <summary> Error message handler - append or insert to current string builder message
        /// </summary>
        /// <param name="sbMessage">Referenced current string builder message</param>
        /// <param name="message">String to append or insert</param>
        /// <param name="append">True to append, false to insert (at beginngin)</param>
        /// <param name="functionName">Function name affected</param>
        /// <returns>Formatted error message with function</returns>
        public string PostMsg(ref StringBuilder sbMessage, string message, bool append, string functionName)
        {
            if (append == true) sbMessage.Append(message);
            else sbMessage.Insert(0, message);
            if (functionName != null) sbMessage.Append("[" + functionName + "]\r\n");
            return sbMessage.ToString();
        }
        /// <summary> Error message handler - append or insert to current string builder message
        /// </summary>
        /// <param name="sbMessage">Referenced current string builder message</param>
        /// <param name="message">String to append or insert</param>
        /// <param name="append">True to append, false to insert</param>
        /// <returns>Resultant string</returns>
        public string PostMsg(ref StringBuilder sbMessage, string message, bool append)
        {
            if (append == true) sbMessage.Append(message);
            else sbMessage.Insert(0, message);
            return sbMessage.ToString();
        }


    }
}
