using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginScreen
{
    internal class GlobalVariablesClass
    {
        private static string v1 = "";

        public static string vOne
        {
            get { return v1; }
            set { v1 = value; }
        }
    }
}
