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
    public class Dog : Animal
    {
        public override string Talk()
        {
            return "Bow";
        }
    }
    public class Cat : Animal
    {
        public override string Talk()
        {
            return "Meow";
        }
    }
    public class Elephant : Animal 
    {
        public override string Talk()
        {
            return "Gre";
        }
    }
    public class Animal
    {
        public virtual string Talk()
        {
            return "Implement...";
        }
        public void RandomAnimal()
        {

            Dog dog1 = new Dog(); 
            Dog dog2 = new Dog(); 
            Dog dog3 = new Dog(); 

            Cat cat1 = new Cat(); 
            Cat cat2 = new Cat(); 

            Elephant elephant1 = new Elephant(); 
            Elephant elephant2 = new Elephant(); 


            Animal[] lstAnimal = { dog1, dog2, cat1, cat2, elephant1, elephant2 };
            for (int i = 0; i < lstAnimal.Length ;++i)
            {
                Console.WriteLine(lstAnimal[i].Talk());
            }
        }
    }
}
