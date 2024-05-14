using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton _instance;

        protected Singleton() { }

        public static Singleton Instance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance();
            Singleton singleton2 = Singleton.Instance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Оба экземпляра одинаковы");
            }
            else
            {
                Console.WriteLine("Экземпляры не одинаковы");
            }
        }
    }
}
