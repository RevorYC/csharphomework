using System;

namespace clock
{
    public delegate void ClockAction(int args);
    public class ClockEvent
    {
        public event ClockAction OnTick;
        public event ClockAction OnAlarm;

        public void Tick(int tick)
        {

            OnTick(tick);
        }
        public void Alarm(int alarm)
        {

            OnAlarm(alarm);
        }
    }
    public class Clock
    {
        public ClockEvent clock1 = new ClockEvent();
        private int tick = 0;
        private int alarm = 0;

        public void setAlarm(int var)
        {
            alarm = var;
        }

        public Clock()
        {
            alarm = 0;
            clock1.OnAlarm += new ClockAction(Clock_OnAlarm);
            clock1.OnTick += new ClockAction(Clock_OnTick);
        }
        void Clock_OnTick(int tick)
        {
            Console.WriteLine(" 现在时间是" + tick+"秒");
        }
        void Clock_OnAlarm(int alarm)
        {
            Console.WriteLine(alarm + "秒到了");
        }
        public void ClockRun()
        {
            while (true)
            {
                clock1.Tick(tick);
                if (tick == alarm)
                {
                    clock1.Alarm(alarm);
                }
                tick++;
                System.Threading.Thread.Sleep(1000);
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("请输入闹钟时间");
            a = Console.ReadLine();
            int b = Convert.ToInt32(a);
            Clock test = new Clock();
            test.setAlarm(b);
            test.ClockRun();

        }
    }

}

