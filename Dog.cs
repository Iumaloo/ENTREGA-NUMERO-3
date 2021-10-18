using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public class Dog : Observer
    {
        
        public Dog (string name): base( name)
        {

        }


        public void Smell(Dog dog, Cat cat)
        {
            cat.RegisterObserver(cat, dog);
            Console.WriteLine($"{ dog.name}  Just smelled  {cat.name}");
        }
    }
}
