using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace exercicioBanco
{
    public class Banco
    {
        public int Numero { get; private set; }
        public String Titular  { get; set; }
        public double Saldo { get; private set; }
        
        public Banco(int numero,string titular)  {
            Numero = numero;
            Titular = titular;
        }

        public Banco(int numero,string titular, double depositoIncial) {
           Deposito(depositoIncial);
        }
        // é melhor dessa maneira, pois no futuro se a lógica da operação de deposito mudar, vai se refletir no construtor banco de três argumentos 

        public void Deposito (double quantia){
            Saldo += quantia;
        }
        public void Saque(double quantia){
            Saldo -= quantia + 5.0;
        }
        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", TItular: "
            + Titular 
            + ", Saldo : $"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}