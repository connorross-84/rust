using System;

namespace App
{
    public class HybridService
    {
        private int _state;

        public HybridService(int seed) => _state = seed;

        public int decode(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 29) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new HybridService(29);
            Console.WriteLine(obj.decode(29));
        }
    }
}
