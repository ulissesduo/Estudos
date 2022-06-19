using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (s/n)");

            Conta conta = new Conta(numero, titular);
            
            char depInicial = char.Parse(Console.ReadLine());
            if(depInicial == 's'){    
                Console.WriteLine("Entre o valor do depósito inicial: ");
                conta.Saldo = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine("Entre com o valor do depósito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta.Deposito(quantia);

            Console.WriteLine("Dados atualizados: "+ conta);

            Console.WriteLine("Entre com o valor do saque: ");
            quantia = double.Parse(Console.ReadLine());
            if(quantia == 0){    
                Console.WriteLine("Dados atualizados: "+ conta);
            }
            else{
                conta.Saque(quantia);
                Console.WriteLine("Dados atualizados: "+ conta);
            }
        }
    }
}