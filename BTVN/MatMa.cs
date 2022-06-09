using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*
     3/ Cho A = 1, B = 2...., Z = 24. Viết hàm dịch câu: "code for your life" (2 point)
    In ASCII table, A = 65 => A = 65-64
     */
    public class MatMa
    {
        public string GiaiMatMa(string matma)
        {
            string result = "";
            foreach(char c in matma.ToUpper())
            {
                if (c==32) result += " - ";
                else result += (c-64+" ");
            }
            return result;
        }
    }
}
