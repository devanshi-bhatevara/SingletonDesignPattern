using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    //works perfectly fine in a single threaded app but not with multi threaded

    //why sealed keyword??
    public sealed class Singleton
    {
        private static int counter;

        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                //this is lazy initialization and it works fine in single threaded environment 
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        //private ctor ensures that object is not instantiated other than within the class itself
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

    //if a simple class outside this class wil try to inherit this class it won't allow because of the private constructor then why bother using the sealed keyword
    //but if a nested class does it will allow it
    public class SingletonWithoutSealed
    {
        private static int counter;

        private static SingletonWithoutSealed instance = null;
        public static SingletonWithoutSealed GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new SingletonWithoutSealed();
                return instance;
            }
        }
        private SingletonWithoutSealed()
        {
            counter++;
            Console.WriteLine("Counter {0}", counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

        public class DerivedClass : SingletonWithoutSealed
        {

        }
    }

    public sealed class SingletonWithLocks
    {
        private static int counter;

        private static readonly object lockObject = new object();

        private static SingletonWithLocks instance = null;
        public static SingletonWithLocks GetInstance
        {
            get
            {
                //double check locking
                if (instance == null)
                {
                    //locks are very expensive so we should avoid hitting locks everytime
                    lock (lockObject)
                    {
                        //this is lazy initialization and it works fine in single threaded environment 
                        if (instance == null)
                            instance = new SingletonWithLocks();
                    }
                }
                return instance;
            }
        }

        //private ctor ensures that object is not instantiated other than within the class itself
        private SingletonWithLocks()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }


    //it is default thread safe as CLR takes care of it
    public sealed class SingletonEagerLoading
    {
        private static int counter;

        private static readonly SingletonEagerLoading instance = new SingletonEagerLoading();
        public static SingletonEagerLoading GetInstance
        {
            get
            {
                return instance;
            }
        }

        private SingletonEagerLoading()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    } 
    

    //lazy objects are by default thread safe
    public sealed class SingletonLazyInitialization
    {
        private static int counter;

        private static readonly Lazy<SingletonLazyInitialization> instance = new Lazy<SingletonLazyInitialization>(()=> new SingletonLazyInitialization());
        public static SingletonLazyInitialization GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private SingletonLazyInitialization()
        {
            counter++;
            Console.WriteLine(counter);
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }

}
