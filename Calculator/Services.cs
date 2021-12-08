using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator
{
    public class Services
    {
        public bool checkOp(String s)
        {
            if (s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/"))
                return true;
            else
                return false;
        }

        public int getResult(int nb1, int nb2, String op) {
            if (op == "+")
                return nb1 + nb2;
            else if (op == "*")
                return nb1 * nb2;
            else if (op == "-")
                return nb1 - nb2;
            else
                return nb1 / nb2;
        }
    }
}
