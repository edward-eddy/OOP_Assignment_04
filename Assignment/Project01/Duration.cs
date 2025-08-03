namespace Assignment.Project01
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public Duration(int seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Hours = time.Hours;
            Minutes = time.Minutes;
            Seconds = time.Seconds;
        }

        public static Duration operator +(Duration left, Duration right)
        {
            Duration Return = new Duration(
                                            left.Hours + right.Hours,
                                            left.Minutes + right.Minutes,
                                            left.Seconds + right.Seconds
                                            );

            int mTemp = Return.Minutes, sTemp = Return.Seconds;

            mTemp += sTemp / 60;
            Return.Seconds = sTemp % 60;
            Return.Minutes = mTemp % 60;
            Return.Hours += mTemp / 60;

            return Return;
        }
        public static Duration operator +(Duration left, int right)
        {
            Duration Right = new Duration(right);
            Duration Return = left + Right;
            return Return;
        }
        public static Duration operator +(int left, Duration right)
        {
            Duration Left = new Duration(left);
            Duration Return = Left + right;
            return Return;
        }
        public static Duration operator ++(Duration duration)
        {
            duration.Minutes++;
            return duration;
        }
        public static Duration operator --(Duration duration)
        {
            duration.Minutes--;
            return duration;
        }
        public static Duration operator -(Duration left, Duration right)
        {
            TimeSpan LeftTimeSpan = new TimeSpan(left.Hours, left.Minutes, left.Seconds);
            TimeSpan RightTimeSpan = new TimeSpan(right.Hours, right.Minutes, right.Seconds);

            Duration Return = new Duration((int)LeftTimeSpan.TotalSeconds - (int)RightTimeSpan.TotalSeconds);

            return Return;
        }

        public static bool operator >(Duration left, Duration right)
        {
            TimeSpan LeftTimeSpan = new TimeSpan(left.Hours, left.Minutes, left.Seconds);
            TimeSpan RightTimeSpan = new TimeSpan(right.Hours, right.Minutes, right.Seconds);

            return LeftTimeSpan.TotalSeconds > RightTimeSpan.TotalSeconds;
        }

        public static bool operator <(Duration left, Duration right)
        {
            TimeSpan LeftTimeSpan = new TimeSpan(left.Hours, left.Minutes, left.Seconds);
            TimeSpan RightTimeSpan = new TimeSpan(right.Hours, right.Minutes, right.Seconds);

            return LeftTimeSpan.TotalSeconds < RightTimeSpan.TotalSeconds;
        }

        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours : {Hours}, Minutes : {Minutes}, Seconds : {Seconds} ";
            }
            else if (Minutes > 0)
            {
                return $"Minutes : {Minutes}, Seconds : {Seconds} ";
            }
            else
            {
                return $"Seconds : {Seconds} ";
            }
        }

    }
}

