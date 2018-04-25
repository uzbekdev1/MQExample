using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzEx.TMQ.Helpers
{
    public static class MQHelper
    {
        public static string Encode(string s)
        {
            var data = Encoding.UTF8.GetBytes(s);

            return Convert.ToBase64String(data);
        }

        public static string Decode(string s)
        {
            var data = Convert.FromBase64String(s);

            return Encoding.UTF8.GetString(data);
        }

    }
}
