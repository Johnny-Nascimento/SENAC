using System.Timers;

namespace Exercicios
{
    public class Musica
    {
        public Musica(Guid id, string nome, string banda, TimeOnly duracao)
        {
            Id = id;
            Nome = nome;
            Banda = banda;
            Duracao = duracao;
        }

        public Guid Id { get; }
        public string Nome { get; }
        public string Banda { get; }
        public TimeOnly Duracao { get; set; }
    }

    public class BibliotecaDeMusicas
    {
        public BibliotecaDeMusicas(List<Musica> musicas, byte volume)
        {
            Musicas = musicas;
            MusicasAnteriores = new List<Musica>();
            Volume = volume;
        }

        public async void PlayRandom()
        {
            var ids = Musicas.Select(x => x.Id).ToList();

            var index = new Random().Next(ids.Count);
            Play(ids[index]);
        }

        private static void OnTocandoMusica(Object source, ElapsedEventArgs e, Musica musica)
        {
            Console.Clear();
            Console.WriteLine($"Tocando {musica.Nome} - {musica.Banda} | {musica.Duracao.ToLongTimeString()}");
            Console.WriteLine("Aperte enter para parar");

            if (musica.Duracao.Ticks == 0)
                ((System.Timers.Timer)source).Dispose();

            musica.Duracao = musica.Duracao.Add(new TimeSpan(0, 0, -1));
        }

        private static void OnDisposed(object sender, EventArgs e)
        {
            Console.WriteLine("Fim Musica.");
        }

        public async void Play(Guid id)
        {
            Musica? musica = Musicas.Find(m => m.Id == id);

            if (musica == null)
                throw new Exception("Musica não encontrada");

            MusicasAnteriores.Add(musica);

            System.Timers.Timer timer = new System.Timers.Timer(1000f);

            timer.Elapsed += (sender, e) => OnTocandoMusica(sender, e, musica);
            timer.Disposed += OnDisposed;
            timer.AutoReset = true;
            timer.Start();

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                {
                    if (timer.Enabled)
                        timer.Dispose();
                }
                break;

                case ConsoleKey.RightArrow:
                    ProximaMusica();
                break;

                case ConsoleKey.LeftArrow:
                    MusicaAnterior();
                break;

                case ConsoleKey.Add:
                    AumentaVolume();
                break;

                case ConsoleKey.Subtract:
                    AbaixaVolume();
                break;
            }
        }

        private void AbaixaVolume()
        {
            Volume--;
        }

        private void AumentaVolume()
        {
            Volume++;
        }

        private void MusicaAnterior()
        {
            if (MusicasAnteriores.Count == 0)
                Console.WriteLine("Não existe música anterior.");

            Play(MusicasAnteriores.Last().Id);
        }

        private void ProximaMusica()
        {
            throw new NotImplementedException();
        }

        public List<Musica> Musicas { get; }
        public List<Musica> MusicasAnteriores { get; }
        public byte Volume { get; set; }
    }
}
