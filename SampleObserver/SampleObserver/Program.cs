// See https://aka.ms/new-console-template for more information
using SampleObserver.Publisher;
using SampleObserver.Subscriber;

Console.WriteLine("Hello, World!");
ISubscriber subscriber1 = new WidgetTelegram();
ISubscriber subscriber2 = new WidgetVk();
ISubscriber subscriber3 = new WidgetIcq();

IPublisher publisher = new NewAgrigator();

publisher.subscribe(subscriber1);
publisher.subscribe(subscriber2);   
publisher.subscribe(subscriber3);

publisher.notify();
Console.WriteLine("-----------------------");
publisher.unsubscribe(subscriber1);
publisher.notify();
Console.WriteLine("-----------------------");
