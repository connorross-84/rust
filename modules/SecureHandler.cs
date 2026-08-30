using System;

namespace App
{
    public class SharedRegistry
    {
        private int _state;

        public SharedRegistry(int seed) => _state = seed;

        public int build(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 28) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new SharedRegistry(28);
            Console.WriteLine(obj.build(28));
        }
    }
}
