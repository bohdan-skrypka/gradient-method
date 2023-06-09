using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sintax_Analizator
{
    class Parser
    {
        public static double Eval(char[] expr)
        {
            return parseSumm(expr, 0);
        }

        private static double parseSumm(char[] expr, int index)
        {
            double x = parseFactors(expr,ref index);
            while(true)
            {
                char op = expr[index];
                if (op!='+' && op!='-')
                    return x;
                index++;
                double y = parseFactors(expr, ref index);
                if (op == '+')
                    x += y;
                else
                    x -= y;
            }
        }

        private static double parseFactors(char[] expr, ref int index)
        {
            double x = GetDouble(expr,ref index);
            while (true)
            {
                char op = expr[index];
                if (op !='/' && op !='*' && op!='^')
                    return x;
                index++;
                double y = GetDouble(expr,ref index);
                if (op == '/' && y != 0)
                    x /= y;
                else if (op == '*')
                    x *= y;
                else if (op == '^')
                    x = Math.Pow(x, y);
            }
        }

        private static double GetDouble(char []expr,ref int index)
        {
            string dbl = "";
            while((int)expr[index]>=48 && (int)expr[index]<=57 || (int) expr[index]==46)
            {
                dbl += expr[index].ToString();
                index++;
                if (index==expr.Length)
                {
                    index--;
                    break;
                }

            }
            return double.Parse(dbl);
        }
    }
}
