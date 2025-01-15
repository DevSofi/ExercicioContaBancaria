using System.Globalization;
using exercicioBanco;

Banco conta;

System.Console.Write( "Entre o número da conta: " );
int numero = int.Parse(Console.ReadLine());

System.Console.Write("Entre com o nome: ");
string titular = Console.ReadLine();

System.Console.Write("Haverá deposito inicial (s/n)? " );
char resp = char.Parse(Console.ReadLine());

if(resp =='s' || resp == 'S') {
    System.Console.Write("Entre o valor de depósito incial: ");
    double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    conta = new Banco(numero,titular,depositoInicial);
}
else {
    conta = new Banco(numero,titular);
}

System.Console.WriteLine();
System.Console.Write("Dados da conta: ");
System.Console.WriteLine(conta);

System.Console.WriteLine();
System.Console.Write("entre em valor para depósito: ");
double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
conta.Deposito(quantia);
System.Console.Write("Dados da conta atualizados: ");
System.Console.WriteLine(conta);

System.Console.WriteLine();
System.Console.Write("Entre em valor para saque: ");
 quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
conta.Saque(quantia);
System.Console.Write("Dados da conta atualizados: ");
System.Console.WriteLine(conta);

