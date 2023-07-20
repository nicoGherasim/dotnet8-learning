using System.Text;

namespace csharpintro
{
    internal class MemoryManagement
    {
        public void Go()
        {
            Console.WriteLine("go");

            int x = 10;
            int y = 29;

            Console.WriteLine($"{x}, {y}");

            y = x;
            Console.WriteLine($"{x}, {y}");

            y = 345;
            Console.WriteLine($"{x}, {y}");

            Sample sample = new Sample();
            sample.id = 123;

            // shallow copy
            Sample sample1 = sample;
            Console.WriteLine($"{sample.id}, {sample1.id}");

            sample1.id = 456;
            Console.WriteLine($"{sample.id}, {sample1.id}");

            // deep copy
            Sample sample2 = new Sample
            {
                id = sample.id
            };
            Console.WriteLine($"{sample.id}, {sample2.id}");
            sample2.id = 2;
            Console.WriteLine($"{sample.id}, {sample2.id}");

            Sample sample3 = (Sample) sample.Clone();
            Console.WriteLine($"{sample.id}, {sample3.id}");
            sample3.id = -100;
            Console.WriteLine($"{sample.id}, {sample3.id}");

            string name = "ana";
            name += " maria";
            Console.WriteLine(name);

            StringBuilder stringBuilder = new StringBuilder("ana");
            stringBuilder.Append(" maria");
            Console.WriteLine(stringBuilder);

            int i = 123;
            object o = i; // implicit boxing
            object o1 = (object)i; // explicit boxing

            object o2 = 123;
            int i1 = (int)o2; // explicit unboxing
        }
    }

    public class Sample : ICloneable
    {
        public int id;

        public object Clone()
        {
            return new Sample
            {
                id = this.id
            };
        }
    }
}
