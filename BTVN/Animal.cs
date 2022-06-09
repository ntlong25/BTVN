using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN
{
    /*
     2/ Cho 3 lớp tương ứng 3 con vật: Chó, mèo, voi. Mỗi con vật đều có khả năng nói (method).
            Viết vòng lặp sao cho, mỗi khi tới con vật xác định sẽ nói câu tương ứng (không được tạo thuộc tính trong class): (2 point)
            Chó: Bow
            Mèo: Meow
            Voi: Gre
     */
    public class Dog
    {
        public string Talk()
        {
            return "Bow";
        }
    }
    public class Cat
    {
        public string Talk()
        {
            return "Meow";
        }
    }
    public class Elephant
    {
        public string Talk()
        {
            return "Gre";
        }
    }
    public class Animal
    {
        public void RandomAnimal()
        {
            string[] lstAnimal = new string[9];

            Dog dog1 = new Dog(); lstAnimal[0] = dog1.Talk();
            Dog dog2 = new Dog(); lstAnimal[1] = dog2.Talk();
            Dog dog3 = new Dog(); lstAnimal[2] = dog3.Talk();

            Cat cat1 = new Cat(); lstAnimal[3] = cat1.Talk();
            Cat cat2 = new Cat(); lstAnimal[4] = cat2.Talk();
            Cat cat3 = new Cat(); lstAnimal[5] = cat3.Talk();

            Elephant elephant1 = new Elephant(); lstAnimal[6] = elephant1.Talk();
            Elephant elephant2 = new Elephant(); lstAnimal[7] = elephant2.Talk();
            Elephant elephant3 = new Elephant(); lstAnimal[8] = elephant3.Talk();

            for(int i = 0; i < lstAnimal.Length ;++i)
            {
                Console.WriteLine(lstAnimal[i]);
            }
        }
    }
}
