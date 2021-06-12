using System;

namespace OrganizadorDeVagoes
{
    public class Program
    {
        static void Main(string[] args)
        {

			int ncasos, tamanhoTrem,  i;
			int[] vagoes;

			Console.WriteLine("Quantidade de Casos");
			ncasos = Convert.ToInt32(Console.ReadLine());

			while (ncasos > 0)
			{
				Console.WriteLine("Tamanho do trem");
				tamanhoTrem = Convert.ToInt32(Console.ReadLine());
				vagoes = new int[tamanhoTrem];

				for (i = 0; i < tamanhoTrem; i++)
                {
					Console.WriteLine("Insira o número do Vagão: " + (i + 1));
					vagoes[i]= Convert.ToInt32(Console.ReadLine());
				}

				int resultado = ordenaVagoes(vagoes, tamanhoTrem);
				Console.WriteLine("Optimal train swapping takes "+ resultado +"  swaps." );

				ncasos--;
			}

		}

		private static int ordenaVagoes(int[] vet, int tam) // Ordena os vagoes e retorna a quantidade de movimentações
		{

			int  i, j, cont = 0, aux;

			while (tam > 0)
			{

				for (i = 0, j = 1; i < tam-1; i++, j++)
					if (vet[i] > vet[j])
					{
						cont++;
						aux = vet[i];
						vet[i] = vet[j];
						vet[j] = aux;
					}
				tam--;
			}
			return cont;// Retorna a quantidade de movimentações.
		}
	}
}
