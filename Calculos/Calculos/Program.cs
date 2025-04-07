/* EXERCICIO Sala

Console.WriteLine("Faça o calculo do juros simples.");
double C, I, T, J;
Console.WriteLine("Qual o valor do Capital: ");
C = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Qual o valor da taxa(em decimal): ");
I = Convert.ToDouble(Console.ReadLine());
I = I / 100;
Console.WriteLine("Qual o tempo previsto(em dias): ");
T = Convert.ToDouble(Console.ReadLine());
J = C * I * T;
Console.WriteLine("O valor do juros simples é de " + J + " reais.");
*/

/* EXERCICIO 11

Console.WriteLine("Compare o valor de dois valores, verificando quem é o maior ou o menor.");
double A, B;
Console.WriteLine("Digite o valor A:");
A = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o valor B:");
B = Convert.ToDouble(Console.ReadLine());
if (A >= B)
{
    Console.WriteLine("O maior valor é A");
}else if (B >= A)
{
    Console.WriteLine("O maior valor é B");
}
else
{
    Console.WriteLine("Os Valores são iguais, então a verificação não sera possivel confirmar.");
}
*/

/* EXERCICIO 18

Console.WriteLine("Verifique se o código é válido.");
int CODIGO, A, B, C;

Console.WriteLine("Crie valores inteiros que validem o código abaixo:");
Console.WriteLine("Crie o valor A, B e C sucessivamente:");
A = Convert.ToInt32(Console.ReadLine());
B = Convert.ToInt32(Console.ReadLine());
C = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Verifique agora se o sistema funciona perfeitamente ao digitar o mesmo valor correspondente ao pedido anterior:");
CODIGO = Convert.ToInt32(Console.ReadLine());

switch (CODIGO)
{
    case var _ when CODIGO == A:
        Console.WriteLine("O valor do código está correto.");
        break;
    case var _ when CODIGO == B:
        Console.WriteLine("O valor do código está correto.");
        break;
    case var _ when CODIGO == C:
        Console.WriteLine("O valor do código está correto.");
        break;
    default:
        Console.WriteLine("O código é inválido!!!!!");
        break;
}
*/

/* EXERCICIO 23

Console.WriteLine("Criar um menu para funções de calculo simples");
double A, B,soma,dividir,multiplicar,subtrair;
int OP;

Console.WriteLine("Decida qual função deseja realizar de acordo com a ordem:");
Console.WriteLine("1- Função de Somar");
Console.WriteLine("2- Função de Subtrair");
Console.WriteLine("3- Função de Multiplicar");
Console.WriteLine("4- Função de Dividir");

OP = Convert.ToInt32(Console.ReadLine());

switch (OP)
{
    case 1:
        Console.WriteLine("Digite o valor A:");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor B:");
        B = Convert.ToDouble(Console.ReadLine());
        soma = A + B;
        Console.WriteLine("O valor da soma resultara em: " + soma);
        break;
    case 2:
        Console.WriteLine("Digite o valor A:");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor B:");
        B = Convert.ToDouble(Console.ReadLine());
        subtrair = A - B;
        Console.WriteLine("O valor da subtração resultara em: " + subtrair);
        break;
    case 3:
        Console.WriteLine("Digite o valor A:");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor B:");
        B = Convert.ToDouble(Console.ReadLine());
        multiplicar = A * B;
        Console.WriteLine("O valor da multiplicação resultara em: " + multiplicar);
        break;
    case 4:
        Console.WriteLine("Digite o valor A:");
        A = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor B:");
        B = Convert.ToDouble(Console.ReadLine());
        dividir = A / B;
        Console.WriteLine("O valor da divisão resultara em: " + dividir + " ,mas arredondado resultado será: " + Math.Round(dividir,2));
        break;
    default:
        Console.WriteLine("A função desejada é inválida!!!!!");
        break;
}
*/

/* EXERCICIO 26

Console.WriteLine("Em ordem crescente mostrar o valor inicial até o valor desejado.");
int inicial, final, par, impar;
par = 0;
impar = 0;
Console.WriteLine("Digite o valor que irá iniciar a ordem crescente: ");
inicial = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor final: ");
final = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-----------------------------------------------------");
if (inicial > final)
{
    Console.WriteLine("Os valores não se enquadram ao objetivo do exercício, REFAÇA!!!");
}
else
{
    while (inicial <= final)
    {
        if (inicial % 2 == 0)
        {
            par++;
        }
        else
        {
            impar++;
        }
        Console.WriteLine(inicial);  
        inicial++;
    }
    Console.WriteLine("-----------------------------------------------------");
    Console.WriteLine("O número de valores pares foi: " + par + " ,e os ímpares foram: " + impar);
}
*/

/* EXERCICIO 37*/

Console.WriteLine("Criar um menu para funções de calculo simples e manter a opção de sair ou não do programa.");
double A, B, soma, subtrair, multiplicar, dividir;
bool continuar = true;
int OP;
string resposta;

while (continuar)
{
  Console.WriteLine("Decida qual função deseja realizar de acordo com a ordem:");
  Console.WriteLine("1- Função de Somar");
  Console.WriteLine("2- Função de Subtrair");
  Console.WriteLine("3- Função de Multiplicar");
  Console.WriteLine("4- Função de Dividir");

  OP = Convert.ToInt32(Console.ReadLine());

     switch (OP)
     {
      case 1:
            Console.WriteLine("Digite o valor A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            B = Convert.ToDouble(Console.ReadLine());
            soma = A + B;
            Console.WriteLine("O valor da soma resultará em: " + soma);
            break;

      case 2:
            Console.WriteLine("Digite o valor A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            B = Convert.ToDouble(Console.ReadLine());
            subtrair = A - B;
            Console.WriteLine("O valor da subtração resultará em: " + subtrair);
            break;

      case 3:
            Console.WriteLine("Digite o valor A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            B = Convert.ToDouble(Console.ReadLine());
            multiplicar = A * B;
            Console.WriteLine("O valor da multiplicação resultará em: " + multiplicar);
            break;

      case 4:
            Console.WriteLine("Digite o valor A:");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor B:");
            B = Convert.ToDouble(Console.ReadLine());
            if (B != 0)
            {
             dividir = A / B;
             Console.WriteLine("O valor da divisão resultará em: " + dividir + " ,mas arredondado resultado será: " + Math.Round(dividir, 2));
            }
             else
             {
              Console.WriteLine("Erro: Não é possível dividir por zero.");
             }
              break;

      default:
            Console.WriteLine("A função desejada é inválida!!!");
            break;
     }

     Console.WriteLine("Deseja realizar outra operação? (S/N): ");
     resposta = Console.ReadLine();
     if (resposta.ToUpper() != "S")
     {
       continuar = false;
     }
}
  Console.WriteLine("Programa encerrado.");
  

