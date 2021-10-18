using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public class Canary : Observer
    {
        public Canary(string name) : base(name)
        {

        }

        public void See(Canary canary, Cat cat)
        {
            cat.RegisterObserver(cat, this);
          Console.WriteLine($"{canary.name} Just saw { cat.name}");
        }

    }
}
