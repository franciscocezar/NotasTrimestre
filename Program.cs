/*O programa deve ler o nome de um(a) aluno(a) e as três notas 
 * que ele(a) obteve nos três trimestres do ano (primeiro trimestre 
 * vale 30 e o segundo e terceiro valem 35 cada). E então, mostrar 
 * qual a nota final do(a) aluno(a) no ano. Dizer também, se o(a) aluno(a) 
 * está APROVADO ou REPROVADO e, em caso negativo, quantos pontos 
 * faltaram para ele(a) obter o mínimo para ser aprovado(a) (que é 60 pontos). 
*/

using System;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno a = new Aluno();


            Console.Write("Nome do(a) aluno(a): ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do(a) aluno(a):");
            a.Nota1 = double.Parse(Console.ReadLine());
            a.Nota2 = double.Parse(Console.ReadLine());
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + a.NotaFinal().ToString("F2"));

            if(a.NotaFinal() > 60)
            {
                Console.WriteLine("APROVADO(A)");
            }
            else
            {
                Console.WriteLine("REPROVADO(A)");
                Console.WriteLine("FALTARAM " + a.NotaReprovado().ToString("F2") + " PONTOS");
            }


        }
    }
}
