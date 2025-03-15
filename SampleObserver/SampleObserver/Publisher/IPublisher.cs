using SampleObserver.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObserver.Publisher
{
    internal interface IPublisher
    {
        void subscribe(ISubscriber subscriber);
        void unsubscribe(ISubscriber subscriber);
        void notify();
    }
}
