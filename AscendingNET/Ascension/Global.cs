using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;


[assembly: InternalsVisibleTo("AscendingNET")]

namespace Ascension
{
    internal static class Global
    {
        public enum MathOperators { Add, Sub, Mul, Div };
        public enum UserControls { Menu, Math, UserEdit };

        public const string S_USER_ADDNEW = "Add New Student";
    }

}
