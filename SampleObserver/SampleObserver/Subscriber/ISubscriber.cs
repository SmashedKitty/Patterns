using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObserver.Subscriber
{
    public interface ISubscriber
    {
        void update(string telegram, string vk, string icq);
    }
}
