using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class MyClockRadio
    {

            private string setTime()
            {
                string time = DateTime.Now.ToString("h:mm:ss tt");
                return time;
            }
            private string showTime(string currentTime)
            {
              string time = ("The time is " + currentTime);
            return time;      
            }
            public void RunTime()
            {
                string time = setTime();
                string currentTime = showTime(time);
                Console.WriteLine(currentTime);
            }   

}
}
