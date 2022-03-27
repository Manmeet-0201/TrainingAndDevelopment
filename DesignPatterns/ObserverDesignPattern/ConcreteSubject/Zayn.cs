using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverDesignPattern.Observer;
using ObserverDesignPattern.Subject;

namespace ObserverDesignPattern.ConcreteSubject
{
    public class Zayn : ICelebrity
    {
        private readonly List<IFan> _fans = new List<IFan>();       // Collection
        private string _tweet;                                      // Backing field

        public Zayn(string tweet)
        {                              // Constructor
            _tweet = tweet;
        }

        public string FullName => "Zayn Malik";
        public string Tweet
        {
            get { return _tweet; }

            set
            {
                Notify(value);
            }
        }

        public void AddFollower(IFan fan)
        {
            _fans.Add(fan);
        }

        public void RemoveFollower(IFan fan)
        {
            _fans.Remove(fan);
        }

        public void Notify(string tweet)
        {
            _tweet = tweet;
            foreach (var fan in _fans)
            {
                fan.Update(this);
            }
        }
    }
}
