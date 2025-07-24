namespace Espeiceneitor.Entidades
{
    public class Lancamento
    {
        private static List<Lancamento> _Lancamentos = new List<Lancamento>();

        public static List<Lancamento> Lancamentos
        {
            get
            {
                return new List<Lancamento>(_Lancamentos);
            }
        }
        public Missao Missao { get; private set; }
        public List<Astronauta> Astronautas { get; private set; }

        public Lancamento(Missao missao, List<Astronauta> astronautas)
        {
            Missao = missao;
            Astronautas = astronautas;
        }

        public void Create()
        {
            _Lancamentos.Add(this);
        }
    }
}