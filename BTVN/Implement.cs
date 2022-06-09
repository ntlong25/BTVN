using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*
     5/ Implement 1 method cùng tên trong 2 interface khác tên, và gọi ra để kiểm tra.
     */

    public interface ITinhTong
    {
        string Result();
    }
    public interface ITinhTich
    {
        string Result();
    }
    public class Implement : ITinhTong, ITinhTich
    {
        public string Result()
        {
            return "Implement tong hay tich???";
        }
    }
}
