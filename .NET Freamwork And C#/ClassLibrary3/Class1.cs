using System;



namespace ClassLibrary3
{
    public class Class1
    {
        public void PrintMyName(string name)
        {
            Console.WriteLine(name);
        }
        public int Sum(int x, int y)
        {
            return x + y;
        }
        private int Substract(int x, int y)
        {
            if (x > y)
            {
                return x - y;
            }
            else
            {
                return y - x;
            }
        }
    }
}
