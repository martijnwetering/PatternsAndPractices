using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NodaTime;
using PracticesAndPatterns.Patterns.IocContainer;

namespace PatternsAndPractices.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var injector = new Injector();
            injector.Bind<IClock, SystemClock>();
            injector.Bind<DateTimeZone>(DateTimeZone.Utc);
            injector.Bind<Instant>(Instant.FromUtc(2000, 1, 1, 0, 0, 0));
            injector.Bind<CalendarSystem>(CalendarSystem.Iso);
        }
    }
}
