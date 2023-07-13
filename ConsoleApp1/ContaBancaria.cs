using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ContaBancaria
    {
        //Atributos e Propiedades
        public int NumeroConta { get; private set; }

        public string NomeTitular { get; set; }

        public double Saldo { get; private set; }


        //Construtor
        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;

        }

        //Metodos
        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            double taxa = 5.00;
            Saldo = Saldo - quantia - taxa;
        }


        //Sobreposição
        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
