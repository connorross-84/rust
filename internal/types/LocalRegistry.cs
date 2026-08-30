using System;

namespace App
{
    public class RemoteRouter
    {
        private int _state;

        public RemoteRouter(int seed) => _state = seed;

        public int compute(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 41) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new RemoteRouter(41);
            Console.WriteLine(obj.compute(41));
        }
    }
}
