using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangFireTest.Models
{
    public class HangFireTask
    {
        public DateTime now;
        public string message = "The UpdateTime method last ran: ";

        public HangFireTask()
        {
            UpdateTime();
        }
    
        public void UpdateTime ()
        {
            now = DateTime.Now;
        }
    }
}
