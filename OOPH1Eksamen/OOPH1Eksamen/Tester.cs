using System;
namespace OOPH1Eksamen
{
    public class Tester
    {
        static void Main() {
            new Tester();
        }

        public Tester()
        {
            Console.WriteLine(TestA());
        }

        public bool TestA()
        {
            try {
                Type[] t = { typeof(int), typeof(string), typeof(double) };
                var c = (typeof(A)).GetConstructor(t);
                if (c != null)
                {
                    var o = c.Invoke(new object[] { 1, "2", 3.0 }) as A;
                    return o.a == 1 && o.b == "2" && o.c == 3.0;
                }
            } catch(Exception){}

            return false;
        }
    }
}
