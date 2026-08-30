using System;

namespace App
{
    public class StreamProvider
    {
        private int _state;

        public StreamProvider(int seed) => _state = seed;

        public int handle(int count)
        {
            int total = 0;
            for (int i = 0; i < count; i++)
                total += (_state + i * 4) % 997;
            return total;
        }

        public static void Main()
        {
            var obj = new StreamProvider(4);
            Console.WriteLine(obj.handle(4));
        }
    }
}
