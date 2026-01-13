using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        Cenario1();
        Cenario2();

        Console.ReadKey();
    }
    static void Cenario1()
    {
        int[] arrayEntrada = { 3, 2, 1, 6, 0, 5 };

        var arvore = ConstrutorArvore.Construir(arrayEntrada);

        Console.WriteLine("Árvore gerada:\n");
        ImprimirArvore(arvore, 0);
    }
    static void Cenario2()
    {
        int[] arrayCenario2 = { 7, 5, 13, 9, 1, 6, 4 };
        var arvore = ConstrutorArvore.Construir(arrayCenario2);

        Console.WriteLine("Árvore gerada (Cenário 2):\n");
        ImprimirArvore(arvore, 0);
    }
    static void ImprimirArvore(Arvore no, int nivel)
    {
        if (no == null) return;

        ImprimirArvore(no.Direita, nivel + 1);
        Console.WriteLine(new string(' ', nivel * 4) + no.Value);
        ImprimirArvore(no.Esquerda, nivel + 1);
    }
}
