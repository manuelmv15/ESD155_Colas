namespace colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Cola<int> miCola = new Cola<int>();
            miCola.Encolar(1);
            miCola.Encolar(2);
            miCola.Encolar(3);

            Console.WriteLine("ELemento en la cola");
            miCola.Mostrar();

            miCola.acceder(1);

            miCola.Desencolar();

            miCola.Mostrar();   
        }
    }
}