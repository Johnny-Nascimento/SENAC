namespace Exercicios.Pratica
{
    internal class PraticaDoWhile
    {
        public static void Executar()
        {
            const string SENHA = "ADMIN";
            bool senhaCorreta = false;

            do
            {
                Console.WriteLine("Insira a senha");
                string senhaUsuario = Console.ReadLine();

                senhaCorreta = senhaUsuario == SENHA;
                if (senhaCorreta)
                    Console.WriteLine("Sucesso");
                else
                    Console.WriteLine("Tente novamente");

            } while (!senhaCorreta);
        }
    }
}
