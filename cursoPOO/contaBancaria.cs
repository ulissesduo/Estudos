using System;
using System.Globalization;

namespace POO
{
    class Conta{
        private int _numero;
        public string Titular;
        public double Saldo;

        public Conta(int numero, string titular){
            _numero = numero;
            Titular = titular;
            Saldo = 0;
        }
        public override string ToString(){
            return "Número " + _numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo;
        }
        public int GetNumero(){
            return _numero;
        }
       
        public void Deposito(double quantia){
            Saldo = (Saldo + quantia);
        }
        public void Saque(double quantia){
            Saldo = (Saldo - quantia) - 5.00;
        }
    }
}