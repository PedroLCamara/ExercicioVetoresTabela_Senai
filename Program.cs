using System;

namespace ExercicioTabelaForixi
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quantidade_produtos= null;
            string[] nome_produtos= null;
            float[] valor_produtos= null;
            Console.WriteLine("Quantos produtos serão cadastrados?");
            int num_produtos= int.Parse(Console.ReadLine());
            quantidade_produtos= new int[num_produtos];
            nome_produtos= new string[num_produtos];
            valor_produtos= new float[num_produtos];
            for (var i = 0; i < num_produtos; i++)
            {
                Console.WriteLine($"Qual o nome do {i+1}º produto?");
                nome_produtos[i]= Console.ReadLine();
                Console.WriteLine("Quantas unidades desse produto?");
                quantidade_produtos[i]= int.Parse(Console.ReadLine());
                Console.WriteLine("Qual o preço por unidade?");
                valor_produtos[i]= float.Parse(Console.ReadLine());
            }
            Console.WriteLine($@"
                ===========================================================================
                |   QUANTIDADE   |             NOME             |          VALOR          |");
            for (var i = 0; i <= num_produtos-1; i++)
            {
                Console.WriteLine(@$"
                ===========================================================================
                |    {quantidade_produtos[i]}   |      {nome_produtos[i]}      |    {valor_produtos[i]}  |");
            }  
        }
    }
}
