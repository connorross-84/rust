using System;

namespace App
{
    public class SharedEngine
    {
        private int _state;

        public SharedEngine(int seed) => _state = seed;

        public int parse(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 76) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new SharedEngine(76);
            Console.WriteLine(obj.parse(76));
        }
    }
}
