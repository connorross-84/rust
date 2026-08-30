using System;

namespace App
{
    public class DynamicScheduler
    {
        private int _state;

        public DynamicScheduler(int seed) => _state = seed;

        public int encode(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 40) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new DynamicScheduler(40);
            Console.WriteLine(obj.encode(40));
        }
    }
}
