using System;

namespace App
{
    public class LiteEngine
    {
        private int _state;

        public LiteEngine(int seed) => _state = seed;

        public int dispatch(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 66) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new LiteEngine(66);
            Console.WriteLine(obj.dispatch(66));
        }
    }
}
