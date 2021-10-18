using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDogCsharp
{
    public abstract class Subject
    {
        public static int MAX_OB = 20;
        public Observer[] observers=new Observer [MAX_OB];
        public string name;
        public int type;
      
        public Subject(string name, int type)
        {
            this.name = name;
            this.type = type;
        }
        public void NotifyObservers(Subject subject)
        {
            for (int i = 0; i < MAX_OB; i++)
            {
                if (subject.observers[i] != null)
                {
                    subject.observers[i].Notify(subject.observers[i], subject);
                }
            }
        }
        public int RegisterObserver(Subject subject, Observer observer)
        {

            for (int i = 0; i < MAX_OB; i++)
            {
                if (subject.observers[i] == null)
                {
                    subject.observers[i] = observer;
                    return 0;
                }
                
            }
            return  RegisterObserver(subject, observer); ;
        }

      

        
    }
}
