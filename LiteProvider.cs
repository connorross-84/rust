using System;

namespace App
{
    public class CoreAdapter
    {
        private int _state;

        public CoreAdapter(int seed) => _state = seed;

        public int flush(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 50) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new CoreAdapter(50);
            Console.WriteLine(obj.flush(50));
        }
    }
}
