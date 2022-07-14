namespace desafio2
{

    public enum EnumTipo
    {
        CARRO = 1,
        CAMINHAO
    }

    public class Veiculo
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public EnumTipo Tipo { get; set; }

        public string Placa { get; set; }
    }

    public class Carro : Veiculo
    {
        public int OcupacaoMaxima { get; set; }
    }

    public class Caminhao : Veiculo
    {
        public string Chassi { get; set; }

        public int PesoEmToneladas { get; set; }
    }

    public class ServicoDeCaminhao
    {
        public void InsiraCaminhao(Veiculo carro)
        {

        }

        public Veiculo ObtenhaCaminhao(int codigo)
        {
            return null;
        }

        public List<Veiculo> ObtenhaListaDeCaminhao()
        {
            return null;

        }

        public int ObtenhaQuantidadeDeCaminhoes()
        {
            return 0;
        }
    }
    public class ServicoDeCarro
    {
        public void InsiraCarro(Veiculo carro)
        {
            return;
        }

        public Veiculo ObtenhaCarro(int codigo)
        {
            return null;
        }

        public List<Veiculo> ObtenhaListaDeCarros()
        {
            return null;
        }
    }
}