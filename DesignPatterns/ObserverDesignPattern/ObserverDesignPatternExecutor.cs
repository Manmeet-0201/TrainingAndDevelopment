using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.ConcreteObserver;
using ObserverDesignPattern.ConcreteSubject;

namespace ObserverDesignPattern
{
    class ObserverDesignPatternExecutor
    {
        static void Main(string[] args)
        {
            var zaynMalik = new Zayn("I love my new wife");
            var rizAhmed = new Riz("1981 is now my favorite number.");

            var firstFan = new Fan();
            var secondFan = new Fan();

            zaynMalik.AddFollower(firstFan);
            rizAhmed.AddFollower(secondFan);

            zaynMalik.Tweet = "My wife didn't force me to tweet.";
            rizAhmed.Tweet = "I love my new music.";

            Console.Read();
        }
    }
}
