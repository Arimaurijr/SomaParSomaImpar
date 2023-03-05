internal class Program
{
    private static void Main(string[] args)
    {
        int somaPar = 0, somaImpar = 0, numero, indice = 1;
        bool verifica;

        void Entrada()
        {
            Console.WriteLine("ENTRE COM " + indice + " º NÚMERO");
            numero = int.Parse(Console.ReadLine());
            indice++;
        }

        void verificaParImpar()
        {
            verifica = false;
            if (numero % 2 == 0)
            {
                verifica = true;
            }
        }

        void Iteracao()
        {
            int indice = 0;
            Entrada();
            while (numero < 1000)
            {
                verificaParImpar();
                if (verifica)
                {
                    somaPar += numero;
                }
                else
                {
                    somaImpar += numero;
                }

                indice++;
                Entrada();
            }
        }

        void ExibirSomaPar()
        {
            Console.WriteLine("A SOMA DOS NÚMEROS DOS NÚMEROS PARES É " + somaPar);
        }
        void ExibirSomaImpar()
        {
            Console.WriteLine("A SOMA DOS NÚMEROS DOS NÚMEROS PARES É " + somaImpar);
        }

        Iteracao();
        ExibirSomaPar();
        ExibirSomaImpar();

    }
}