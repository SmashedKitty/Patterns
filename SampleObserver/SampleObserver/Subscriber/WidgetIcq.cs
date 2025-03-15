using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObserver.Subscriber
{
    public class WidgetIcq : ISubscriber
    {
        private string IcqText = "";
        public void update(string telegram, string vk, string icq)
        {
            IcqText = icq;
            display();
        }

        private void display()
        { Console.WriteLine("Icq: {0}", IcqText); }

    }
}
