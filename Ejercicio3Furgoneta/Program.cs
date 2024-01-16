namespace Ejercicio3Furgoneta
{
    class program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Cuanto pesa tu saco");
            int pesoSaco = Convert.ToInt32 (Console.ReadLine());

            int numeroSacosMax = 4000 / pesoSaco;
            Console.WriteLine(numeroSacosMax);
        }
    }
}
