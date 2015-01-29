using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UXLAB
{
    public class countdown
    {
        public Timer timerRef;
        public int timeLeft;
        public int duration;
        public countdown(Timer timer, int timel)
        {
            timerRef = timer;
            timeLeft = timel;
        }
		public countdown(ParticipantControl participant, int timel)
		{
			timerRef = participant.Timer;
			timeLeft = timel;
		}

    }
}
