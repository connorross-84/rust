using System;

namespace App
{
    public class HybridService
    {
        private int _state;

        public HybridService(int seed) => _state = seed;

        public int resolve(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 5) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new HybridService(5);
            Console.WriteLine(obj.resolve(5));
        }
    }
}
