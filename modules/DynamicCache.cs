using System;

namespace App
{
    public class CoreHandler
    {
        private int _state;

        public CoreHandler(int seed) => _state = seed;

        public int load(int count)
        {
            int value = 0;
            for (int i = 0; i < count; i++)
                value += (_state + i * 14) % 997;
            return value;
        }

        public static void Main()
        {
            var obj = new CoreHandler(14);
            Console.WriteLine(obj.load(14));
        }
    }
}
