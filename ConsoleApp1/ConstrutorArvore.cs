using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class ConstrutorArvore
    {
        public static Arvore Construir(int[] array)
        {
            int valorRaiz = array.Max();
            int indiceRaiz = Array.IndexOf(array, valorRaiz);

            var valoresEsquerda = array
                .Take(indiceRaiz)
                .OrderByDescending(x => x)
                .ToList();

            var valoresDireita = array
                .Skip(indiceRaiz + 1)
                .OrderByDescending(x => x)
                .ToList();

            var raiz = new Arvore(valorRaiz);

            raiz.Esquerda = ConstruirGalhoEsquerdo(valoresEsquerda);
            raiz.Direita = ConstruirGalhoDireito(valoresDireita);

            return raiz;
        }

        private static Arvore ConstruirGalhoEsquerdo(List<int> valores)
        {
            if (valores.Count == 0)
                return null;

            var no = new Arvore(valores[0]);
            no.Esquerda = ConstruirGalhoEsquerdo(valores.Skip(1).ToList());
            return no;
        }

        private static Arvore ConstruirGalhoDireito(List<int> valores)
        {
            if (valores.Count == 0)
                return null;

            var no = new Arvore(valores[0]);
            no.Direita = ConstruirGalhoDireito(valores.Skip(1).ToList());
            return no;
        }
    }
}
