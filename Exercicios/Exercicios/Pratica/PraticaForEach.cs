namespace Exercicios.Pratica
{
    internal class PraticaForEach
    {
        public static void Executar()
        {
            List<string> alunos= new List<string>();
            bool ok = false;

            do
            {
                Console.WriteLine("Informe o aluno ou ok para sair");
                string nomeAluno = Console.ReadLine();
                ok = nomeAluno.ToLower() == "ok";

                if (!ok)
                    alunos.Add(nomeAluno);
            }
            while (!ok);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Cadastrada turma");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");

            int id = 1;
            foreach (var aluno in alunos)
                Console.WriteLine($"#{id++} {aluno}");

            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-");
        }
    }
}
