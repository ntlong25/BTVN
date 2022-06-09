using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    class Program
    {
        /*
            1/ Viết hàm cho phép truyền vào 1 số nguyên và trả kết quả giai thừa của số đó.
            2/ Cho 3 lớp tương ứng 3 con vật: Chó, mèo, voi. Mỗi con vật đều có khả năng nói (method).
            Viết vòng lặp sao cho, mỗi khi tới con vật xác định sẽ nói câu tương ứng (không được tạo thuộc tính trong class): (2 point)
            Chó: Bow
            Mèo: Meow
            Voi: Gre
            3/ Cho A = 1, B = 2...., Z = 24. Viết hàm dịch câu: "code for your life" (2 point)
            4/ Tìm số lớn thứ 2 trong mảng
            5/ Implement 1 method cùng tên trong 2 interface khác tên, và gọi ra để kiểm tra.
         */
        static void Main(string[] args)
        {
            GiaiThua giaiThua = new GiaiThua();
            Console.WriteLine($"Giai thua cua {5} la: " + giaiThua.TinhGiaiThua(5));
            
            Animal animal = new Animal();
            animal.RandomAnimal();

            MatMa matMa = new MatMa();
            Console.WriteLine("Giai mat ma: " + matMa.GiaiMatMa("code for your life"));
            
            Top2Max top2Max = new Top2Max();
            int[] arr = { 2, 5, 7, 1, 8 };
            Console.WriteLine("Top 2 trong mang: " + top2Max.Max2(arr));

            Implement implement = new Implement();
            Console.WriteLine(implement.Result());
            Console.ReadKey();
        }
    }
}
