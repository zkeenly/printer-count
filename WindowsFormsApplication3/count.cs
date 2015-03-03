using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    static class count
    {
        //新算法。
        public static void clacbooklet(int page ,ref string ok1,ref string ok2)
        {
            int num = (page+3)/4;
            num = num * 2;//得到中间值。
            int[] a = new int[500];
            int[] b = new int[500];

            for(int i = 1;i<=num ;i++)
            {
                a[i]=i;
            }
            for (int i = num + 1; i <= page; i++)
            {
                b[i] = i;
            }
            for(int i = 1, j=num*2 ; i<=num;i+=2 ,j-=2)
            {
                ok1 += a[i].ToString()+","+b[j].ToString()+","; 
            }
            for (int i = 2, j = num * 2-1; i <= num; i += 2, j -= 2)
            {
                ok2 += a[i].ToString() + "," + b[j].ToString()+",";
            }
        }
        //新算法。
        public static void clacbookletback(int page, ref string ok1, ref string ok2)
        {
            int num = (page + 3) / 4;
            num = num * 2;//得到中间值。
            int[] a = new int[500];
            int[] b = new int[500];

            for (int i = 1; i <= num; i++)
            {
                a[i] = i;
            }
            for (int i = num + 1; i <= page; i++)
            {
                b[i] = i;
            }
            for (int i = 1, j = num * 2; i <= num; i += 2, j -= 2)
            {
                ok1 += a[i].ToString() + "," + b[j].ToString() + ",";
            }
            for (int i = 2, j = num * 2 - 1; i <= num; i += 2, j -= 2)
            {
                ok2 = a[i].ToString() + "," + b[j].ToString() + ","+ok2;
            }
        }



        //计算非小册子算法
        public static void calc(ref string a,ref string b,ref string c,ref string d,
                                ref int i, int page)
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
