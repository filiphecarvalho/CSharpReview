namespace desafio2
{

    public enum EnumTipo
    {
        TERRESTRE,
        AQUATICO = 1,
        AERONAUTICO = 2,
        OUTROS = 3
    }

    public abstract class Veiculo
    {
        public int Codigo { get; set; }

        public string? Descricao { get; set; }

        public EnumTipo Tipo { get; set; }

        public string? Placa { get; set; }

        public string? Chassi { get; set; }
    }

    public class Carro : Veiculo
    {
        public int OcupacaoMaxima { get; set; }
    }

    public class Caminhao : Veiculo
    {
        public int PesoEmToneladas { get; set; }
    }

    public class ServicoDeVeiculo<T> where T : Veiculo
    {
     
        public void InsiraVeiculo(T veiculo)
        {

        }

        public T ObtenhaVeiculo(int codigo)
        {
            return null;
        }

        public List<T> ObtenhaListaDeVeiculos()
        {
            return null;

        }

        public int ObtenhaQuantidadeDeVeiculos(List<T> lista)
        {
            return lista.Count();
        }
    }
}