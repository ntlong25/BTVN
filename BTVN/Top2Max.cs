using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*
     4/ Tìm số lớn thứ 2 trong mảng
     */
    public class Top2Max
    {
        public int Max2(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length-2];
        }
    }
}
