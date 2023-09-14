namespace Exercise2._13_TimeStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Hour = 7;
            time.Minute = 34;
            time.Second = 59;

            Console.WriteLine(time.ToString());

            time = new Time("15:21:34");
            Console.WriteLine(time.ToString());

            time = new Time(12, 33, 24);
            Console.WriteLine(time.ToString());
        }
    }

    internal struct Time
    {
        private const int _maxSeconds = 86400; // 60 * 60 * 24 - Seconds in a day
        private int _secondsSinceMidnight;

        public Time()
        {
            _secondsSinceMidnight = 0;
        }

        public Time(string time)
        {
            Hour = int.Parse(time.Substring(0,2));
            Minute = int.Parse(time.Substring(3,2));
            Second = int.Parse(time.Substring(6,2));
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour
        {
            get
            {
                return _secondsSinceMidnight / 3600;
            }
            set
            {
                if (value < 0) { Console.WriteLine("Hours cannot be less than 0!"); }
                else _secondsSinceMidnight = (_secondsSinceMidnight + value * 3600) % _maxSeconds;
            }

        }
        public int Minute
        {
            get
            {
                return (_secondsSinceMidnight % 3600) / 60;
            }
            set
            {
                if (value > 60 || value < 0) { Console.WriteLine("Minutes cannot be above 60 or less than 0!"); }
                _secondsSinceMidnight = (_secondsSinceMidnight + value * 60) % _maxSeconds;
            }
        }
        public int Second
        {
            get
            {
                return _secondsSinceMidnight % 60;
            }
            set
            {
                if (value > 60 || value < 0) { Console.WriteLine("Seconds cannot be above 60 or less than 0!"); }
                _secondsSinceMidnight = (_secondsSinceMidnight + value) % _maxSeconds;
            }
        }

        public override string ToString()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
    }
}