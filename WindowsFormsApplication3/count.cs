using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    static class count
    {
        public static void calc(ref string a,ref string b,ref string c,ref string d,
                                ref int i,ref int page)
        {
            a = i + ",";
            b = ++i + ",";
            if (i > page)
                b = "00,";
            c = ++i + ",";
            if (i > page)
                c = "00,";
            d = ++i + ",";
            if (i > page)
                d = "00,";
        }
    }
}
