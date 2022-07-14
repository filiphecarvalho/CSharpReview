namespace desafio1
{

    public enum RelacaoParental
    {
        Pai,
        Mae,
        Irmao,
        Amigo,
        Outros
    }

    class Contato
    {
        public int Id { get; set; }
        public Cliente? Cliente { get; set; }
        public string? Nome { get; set; }

        public string? Telefone { get; set; }

        public RelacaoParental TipoRelacao { get; set; }

    }

    class Cliente
    {

        public Cliente()
        {
            contatos = new List<Contato>();
            Id = new Random().Next();
        }

        public void AdicionarContato(Contato contato)
        {
            // Śó permide add contato se for do mesmo cliente e não tiver mesmo telefone e grau de parentesco...
            var cont = contatos.FirstOrDefault(c => c.Cliente?.Id == contato.Cliente?.Id && c.Telefone == contato.Telefone || c.TipoRelacao == contato.TipoRelacao);

            if (cont != null)
            {
                throw new Exception("Contato já existe");
            }

            contatos.Add(contato);
        }

         public void AlterarContato(Contato contato)
        {
            // Śó permide add contato se for do mesmo cliente e não tiver mesmo telefone e grau de parentesco...
            var cont = contatos.FirstOrDefault(
                  c => c.Id == contato.Id && 
                  c.Telefone == contato.Telefone || c.TipoRelacao == contato.TipoRelacao);

            if (cont != null)
            {
                throw new Exception("Contato já existe");
            }

            contatos.Add(contato);
        }

        public Int32 Id { get; set; }
        public string? Nome { get; set; }

        public string? Cpf { get; set; }
        public string? Email { get; set; }


        private List<Contato> getContatos()
        {
            // Sempre ordena a lista pelo Id
            return contatos.OrderBy(c => c.Id).ToList();
        }

        private List<Contato> contatos;

        public List<Contato> Contatos
        {
            get { return getContatos(); }
            set { contatos = value; }
        }
    }

    


}