using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public  class Cat : Subject
    {
    
        public Cat(string name, int type) : base(name, type)
        {
            
        }
      
        public void Speak(Cat cat)
        {
            Console.WriteLine($"My name is {cat.name} miaucitooos");
            NotifyObservers(cat);
        }

      
    }
}
