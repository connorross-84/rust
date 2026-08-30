using System;

namespace App
{
    public class LiteLoader
    {
        private int _state;

        public LiteLoader(int seed) => _state = seed;

        public int decode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 42) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new LiteLoader(42);
            Console.WriteLine(obj.decode(42));
        }
    }
}
