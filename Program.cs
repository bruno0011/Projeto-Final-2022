using System;

namespace Projeto_Final_Calculadora
{
class Program
{
static void Main(string[] args)
{
string opcao;

do
{
exibeMenu();
opcao = Console.ReadLine().Trim().ToUpper();

switch (opcao)
{
case "0":
Console.WriteLine("Projeto realizado para finalização do módulo de programação em C#\n user: Bruno0011");
break;
case "1":
calculaSoma();
break;
case "2":
calculaSubtracao();
break;
case "3":
calculaProduto();
break;
case "4":
calculaDivisao();
break;
case "5":
calculaExponenciacao();
break;
case "6":
calculaRadiciacao();
break;
case "X":
Console.WriteLine("Obrigado por utilizar!");
break;
default:
Console.WriteLine("Funcionalidade indisponível");
break;
}
Console.WriteLine("Pressione qualquer tecla para continuar...\n");
Console.ReadKey();
Console.Clear();
}
while (opcao != "X");

}

static void exibeMenu()
{

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█           Menu           █");
Console.WriteLine("█ [1] - Soma               █");
Console.WriteLine("█ [2] - Subtração          █");
Console.WriteLine("█ [3] - Multiplicação      █");
Console.WriteLine("█ [4] - Divisão            █");
Console.WriteLine("█ [5] - Exponenciação      █");
Console.WriteLine("█ [6] - Radiciação         █");
Console.WriteLine("████████████████████████████");
Console.WriteLine("█ [0] - Sobre o programa   █");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("█ [X] - Sair               █");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("████████████████████████████");
Console.ResetColor();
        }

static void calculaSoma()
        {
double numeroUm, numeroDois, resultado;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█          Soma            █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();

numeroUm = digitaNumeroOrdenado("Primeiro");
numeroDois = digitaNumeroOrdenado("Segundo");

resultado = numeroUm + numeroDois;

Console.WriteLine($"A soma de {numeroUm} + {numeroDois} é igual a {resultado:N2}");
        }

static void calculaSubtracao()
        {
double numeroUm, numeroDois, resultado;

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█          Subtração       █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();


numeroUm = digitaNumeroOrdenado("Primeiro");
numeroDois = digitaNumeroOrdenado("Segundo");

resultado = numeroUm - numeroDois;

Console.WriteLine($"A subtração de {numeroUm} - {numeroDois} é igual a {resultado}");
        }

static void calculaProduto()
        {
double numeroUm, numeroDois, resultado;

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█      Multiplicação       █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();


numeroUm = digitaNumeroOrdenado("Primeiro:");
numeroDois = digitaNumeroOrdenado("Segundo:");

resultado = numeroUm * numeroDois;

Console.WriteLine($"O produto de {numeroUm} x {numeroDois} é igual a {resultado:N2}");
        }

        static void calculaDivisao()
{
double numeroUm, numeroDois, resultado;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█         Divisão          █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();


numeroUm = digitaNumeroOrdenado("Primeiro");
numeroDois = digitaNumeroOrdenado("Segundo");

if (numeroDois == 0)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("Não é possível a divisão por zero!");
Console.ResetColor();
}
else
{
resultado = numeroUm / numeroDois;
Console.WriteLine($"A divisão de {numeroUm} / {numeroDois} é igual a {resultado:N2}");
}
}

static void calculaExponenciacao()
{
double @base, potencia, resultado;

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█      Exponenciação       █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();


@base = digitaNumero("Digite a base ");
potencia = digitaNumero("Digite a potência ");

resultado = Math.Pow(@base, potencia);

Console.WriteLine($"A potência de {@base} elevado a {potencia} é igual a {resultado:N2}");
}

static void calculaRadiciacao()
{
double numero, resultado;
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("████████████████████████████");
Console.WriteLine("█        Radiciação        █");
Console.WriteLine("████████████████████████████");
Console.ResetColor();


numero = digitaNumero("Digite um número ");

if (numero < 0)
{
                Console.WriteLine("Não existem raízes de números negativos!");
}
else
{
resultado = Math.Sqrt(numero);
Console.WriteLine($"A raiz de {numero} é igual a {resultado:N2}");
}
}

static double digitaNumero(string mensagem)
{
double numero = 0;
Console.Write(mensagem);
Double.TryParse(Console.ReadLine(), out numero);
return numero;
}

static double digitaNumeroOrdenado(string ordem)
{
return digitaNumero($"Digite o {ordem} número:");
}


}
}