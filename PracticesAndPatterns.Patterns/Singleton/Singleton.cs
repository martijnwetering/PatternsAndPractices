using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticesAndPatterns.Patterns.Singleton
{
    public class Singleton
    {
        private static class SingletonHolder
        { 
            internal static readonly Singleton Instance = new Singleton();

            // Empty static constructor - forces laziness.
            static SingletonHolder()
            {
            }
        }

        // Internal class SingletonHolder can still call this private constructor.
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get { return SingletonHolder.Instance; }
        }

        public void DoSomething()
        {
            Console.WriteLine("Doing some work!");
        }
    }
}
