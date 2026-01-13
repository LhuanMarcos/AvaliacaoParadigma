using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        int[] arrayEntrada = { 3, 2, 1, 6, 0, 5 };

        var arvore = ConstrutorArvore.Construir(arrayEntrada);

        Console.WriteLine("Árvore gerada:\n");
        ImprimirArvore(arvore, 0);

        Console.ReadKey();
    }

    static void ImprimirArvore(Arvore no, int nivel)
    {
        if (no == null) return;

        ImprimirArvore(no.Direita, nivel + 1);
        Console.WriteLine(new string(' ', nivel * 4) + no.Value);
        ImprimirArvore(no.Esquerda, nivel + 1);
    }
}
