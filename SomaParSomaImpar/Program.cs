// SomaParImpar
internal class Program
{
    private static void Main(string[] args)
    {
        int soma_par, soma_impar, numero;

        soma_par = 0;
        soma_impar = 0;

        Console.WriteLine("Digite um número");
        numero = int.Parse(Console.ReadLine());

        while(numero < 1000)
        {
            if(numero % 2 == 0)
            {
                soma_par += numero;
            }
            else
            {
                soma_impar += numero;
            }

            Console.WriteLine("Digite um número");
            numero = int.Parse(Console.ReadLine());
        }

        if (soma_impar == 0 && soma_par == 0)
        {
            Console.WriteLine("Nenhum número menor que 1000 foi digitado !");
        }
        else
        {
            Console.WriteLine("Soma dos números pares: " + soma_par);
            Console.WriteLine("Soma dos números ímpares: " + soma_impar);
        }
    }
}