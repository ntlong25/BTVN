using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*
     1/ Viết hàm cho phép truyền vào 1 số nguyên và trả kết quả giai thừa của số đó.
     */
    public class GiaiThua
    {
        public int TinhGiaiThua(int number)
        {
            int result = 1;
            while (number > 0)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}
