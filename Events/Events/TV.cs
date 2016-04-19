using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class TV
    {
        public event EventHandler<string> TurnOn;
        public event EventHandler<string> TurnOff;
        public bool TurnedOn { get; private set; } = true;

        public void ChangeState()
        {
            if (TurnedOn)
            {
                OnTurnOn();
            }
            else
            {
                OnTurnOff();
            }
        }
        protected void OnTurnOn()
        {
            TurnedOn = true;
            TurnOn?.Invoke(this, "Turned on");

        }
        protected void OnTurnOff()
        {
            TurnedOn = false;
            TurnOff?.Invoke(this, "Turned off");

        }
    }
}
