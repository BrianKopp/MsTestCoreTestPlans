using System;
using System.Threading;

namespace Library
{
    public class Class1
    {
        public static int Sleep(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            return 0;
        }
    }
}
