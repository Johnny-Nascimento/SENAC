
namespace Exercicios
{
    internal class PraticaArray
    {
        public static void Executar()
        {
            const byte NUMERO_MAX_ALUNOS = 5;

            string[] alunos = new string[NUMERO_MAX_ALUNOS];
            double[] notas = new double[NUMERO_MAX_ALUNOS];

            for (int i = 0; i < NUMERO_MAX_ALUNOS; ++i)
            {
                Console.WriteLine("Informe o nome do aluno");
                string nome = Console.ReadLine();
                alunos[i] = nome;

                Console.WriteLine("Informe a nota do aluno");
                double nota = double.Parse(Console.ReadLine());
                notas[i] = nota;
            }

            for (int i = 0; i < NUMERO_MAX_ALUNOS; ++i)
                Console.WriteLine($"{alunos[i]}: {notas[i]}");
        }
    }
}
