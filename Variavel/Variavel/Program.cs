
/* Teste 1 comentado:
Console.WriteLine("Digite seu nome :");
String nome = Console.ReadLine();
Console.WriteLine("Bem vindo, " + nome + " aluno do curso de Programação de sistemas.");
*/

using System.Security.AccessControl;
/*
Console.WriteLine("Digite os valores de A e B ,respectivamente abaixo:");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int somar = A + B;
int diminuir = A - B;
int multiplicar = A*B;
decimal dividir = A/B;
Console.WriteLine("O valor da soma é:" + somar);
Console.WriteLine("O valor da diminuição é:" + diminuir);
Console.WriteLine("O valor da multiplicação é:" + multiplicar);
Console.WriteLine("O valor da divisão é:" + dividir.ToString();
*/
/*
Console.WriteLine("Digite quantas maçãs você deseja: ");
int QTD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o preço unitario dela: ");
int VL = Convert.ToInt32(Console.ReadLine());
int total = QTD * VL;
Console.WriteLine("O valor total deu cerca de: " + total + " reais");
*/

Console.WriteLine("Digite quantas maçãs você deseja: ");
int QTD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o preço unitario dela: ");
decimal VL = Convert.ToDecimal(Console.ReadLine());
decimal total = QTD * VL;
Console.WriteLine("O valor total deu cerca de: " + total.ToString() + " reais");
