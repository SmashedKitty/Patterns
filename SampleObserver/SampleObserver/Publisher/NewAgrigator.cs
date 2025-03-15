using SampleObserver.Subscriber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleObserver.Publisher
{
    internal class NewAgrigator : IPublisher
    {
        private List<ISubscriber> subscribers;
        private Random random;

        public NewAgrigator()
        {
            
            subscribers = new List<ISubscriber>();
            random = new Random();

        }

        private string getTelegramNews()
        {
            var news = new List<string>()
            {
                "Павел дуров искупался в ванной",
                "нот коин обвалися",
                "телеграм заблокировали"
            };
            return news[random.Next(3)];
        }
        private string getVkNews()
        {
            var news = new List<string>()
            {
                "Мизилина стала женой Шамана",
                "У Вк обновился дизайн",
                "..."
            };
            return news[random.Next(3)];
        }
        private string getIcqNews()
        {
            var news = new List<string>()
            {
                "Большие кочки",
                "это я",
                "я остался один"
            };
            return news[random.Next(3)];
        }
        public void subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);   
        }
        public void notify()
        {
            string telegramText = getTelegramNews();
            string vkText = getVkNews();
            string icqText = getIcqNews();

            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.update(telegramText, vkText, icqText);
            }
        }
        public void unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

    }
}
