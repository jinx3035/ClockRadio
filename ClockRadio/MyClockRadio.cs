using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    public class MyClockRadio
    {

            public string setTime()
            {
                string time = DateTime.Now.ToString("h:mm:ss tt");
                return time;
            }
            public string showTime(string currentTime)
            {
              string time = ("The time is " + currentTime);
            return time;      
                

            }
            
        
    }
}
