namespace EjemploSingleton
{
    class Singleton
    {
        private static Singleton instancia;

        private Singleton() { }

        public static Singleton ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new Singleton();

            return instancia;
        }
    }
}
