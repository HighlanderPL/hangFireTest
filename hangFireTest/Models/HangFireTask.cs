using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangFireTest.Models
{
    public class HangFireTask
    {
        public HangFireTask()
        {
            UpdateTime();
        }
        
        public DateTime now;
        public string message = "The UpdateTime method last ran: ";

        public void UpdateTime ()
        {
            now = DateTime.Now;
        }
    }
}
