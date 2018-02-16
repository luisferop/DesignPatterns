using System;

namespace prjCreational
{
    /// <summary>
    /// Returns only one instance of the class
    /// </summary>
    public class Singleton
    {
        private static Singleton singleton = null;
        private Singleton()
        {
        }
        public static Singleton GetInstance()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }
        public void ExibirDetalhes()
        {
            Console.WriteLine("Singleton chamado!");
        }
    }
}
