using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObserver.Subscriber
{
    internal class WidgetVk : ISubscriber
    {

        private string VkText = "";

        public void update(string telegram, string vk, string icq)
        {
            VkText = vk;
            display();
        }

        private void display()
        { Console.WriteLine("Vk: {0}", VkText); }
    }
}
