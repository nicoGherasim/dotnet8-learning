namespace csharpintro
{
    internal class Keywords
    {
        public void Go()
        {
            Console.WriteLine("go keywords");

            int x = 10;
            int y = 25;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Sum(x, y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            MethodIn(in x);
            Sample s = new Sample();
            MethodIn(in s);

            Console.WriteLine();
            Console.WriteLine(x);
            MethodOut(out x);
            Console.WriteLine(x);

            MethodOut(out int result);
            Console.WriteLine(result);

            int a = 12;
            int b = 13;
            int c = 14;
            Console.WriteLine("a, b, c: " + a +", " + b +", " + c);
            int res1 = MethodWithoutOut(a, b, c);
            Console.WriteLine("a, b, c: " + a + ", " + b + ", " + c);
            Console.WriteLine(res1);

            Console.WriteLine("----------------");

            Console.WriteLine("a, b, c: " + a + ", " + b + ", " + c);
            int res2 = MethodOut(out a, out b,in c);
            Console.WriteLine("a, b, c: " + a + ", " + b + ", " + c);
            Console.WriteLine(res2);

            Console.WriteLine("----------------");
            int d = 10;
            Console.WriteLine(d);
            MethodNoRef(d);
            Console.WriteLine(d);

            Console.WriteLine("----------------");
            d = 10;
            Console.WriteLine(d);
            MethodRef(ref d);
            Console.WriteLine(d);

            Console.WriteLine("----------------");
            Sample sample = new Sample
            {
                id = 1
            };
            Console.WriteLine(sample.id);
            MethodRef(sample);
            Console.WriteLine(sample.id);
        }

        public int Sum(int x, int y)
        {
            x = 123;
            y = 100;
            Console.WriteLine(x + y);
            var sum = x + y;

            return sum;
        }

        public void MethodIn(in int x)
        {
            int y = 345;
            y = x * 2;
            Console.WriteLine(x);
        }

        public void MethodIn(in Sample x)
        {
            int y = 345;
            x.id = 567;
            Console.WriteLine(x.id);
        }

        public void MethodOut(out int x)
        {
            x = 999;
        }

        public void MethodOut(out int x, out int y)
        {
            x = 999;
            y = 678;
        }

        public int MethodWithoutOut(int x, int y, int z)
        {
            Console.WriteLine("no out");
            x = 999;
            y = 678;

            return z * 2;
        }

        public int MethodOut(out int x, out int y, in int z)
        {
            Console.WriteLine("with out");
            x = 999;
            y = 678;

            return z * 2;
        }

        public void MethodRef(ref int x)
        {
            x = 345;
            Console.WriteLine(x);
        }

        public void MethodRef(Sample x)
        {
            x.id = 345;
            Console.WriteLine(x.id);
        }

        public void MethodNoRef(int x)
        {
            x = 345;
            Console.WriteLine(x);
        }
    }
}
