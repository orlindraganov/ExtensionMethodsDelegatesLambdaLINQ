namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public delegate void TimerMethod();

    public class Timer
    {
        private int miliSeconds;
        private byte ticks;
        private TimerMethod currentMethod;

        public byte Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Value cannot be <= 0", "Ticks");
                }

                this.ticks = value;
            }
        }

        public int Interval
        {
            get
            {
                return this.miliSeconds;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be negative", "Interval");
                }

                this.miliSeconds = value * 1000;
            }
        }

        public TimerMethod Method
        {
            get
            {
                return this.currentMethod;
            }
            set
            {
                this.currentMethod = value;
            }
        }

        public Timer(byte ticks, int seconds, TimerMethod currentMethod)
        {
            this.Ticks = ticks;
            this.Interval = seconds;
            this.Method = currentMethod;
        }

        public void Run()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep((int)this.miliSeconds);
                --this.ticks;
                this.currentMethod();
                Console.WriteLine(currentMethod.ToString());
            }
        }
    }

    class Startup
    {
        static void Main()
        {
            TimerMethod testDelegate = TestMethod;

            testDelegate += AnotherTestMethod;
            testDelegate += delegate
            {
                Console.WriteLine("I am anonymous Method");
            };
            Timer testTimer = new Timer(5, 2, testDelegate);
            testTimer.Run();
        }
        private static void TestMethod()
        {
            Console.WriteLine(DateTime.Now);
        }

        private static void AnotherTestMethod()
        {
            Console.WriteLine("After 2 seconds");
        }
    }
}
