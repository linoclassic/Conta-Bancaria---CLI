using System.Globalization;

namespace ConsoleApp1
{

    public class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Entre o número da conta: ");
            int nc = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string tc = Console.ReadLine();

            ContaBancaria cb = new ContaBancaria(nc, tc);

            Console.Write("Haverá um depósito inicial? (S/N): ");
            string resposta = (Console.ReadLine());
            if (resposta.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cb.Depositar(valor);
                Console.WriteLine($"Dados da conta: {cb}"); 
            }
            else
            {
                Console.WriteLine(cb);
            }

            Console.Write("Agora um valor para deposito: ");
            valor = double.Parse(Console.ReadLine());
            cb.Depositar(valor);
            Console.WriteLine($"Dados da conta atualizados: \n {cb} ");

            Console.Write("Agora um valor para saque (Taxa de Saque: R$ 5.00): ");
            valor = double.Parse(Console.ReadLine());
            cb.Sacar(valor);
            Console.WriteLine($"Dados da conta atualizados: \n {cb}");
        }

    }
}
