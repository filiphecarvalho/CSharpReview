
internal class Program
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


    private static void Main(string[] args)
    {
        void printCliente(Cliente cliente)
        {


            Console.WriteLine("--------Dados Cliente ---------");
            Console.WriteLine("");
            Console.WriteLine("Nome: {0}", cliente.Nome);
            Console.WriteLine("CPF: {0}", cliente.Cpf);
            Console.WriteLine("Email: {0}", cliente.Email);
            Console.WriteLine("");

            Console.WriteLine("--------Lista de Contatos ---------");
            var listaContatos = cliente.Contatos;

            foreach (var contato in listaContatos)
            {
                Console.WriteLine("|- Id: {0}", contato.Id);
                Console.WriteLine("|- ClienteId: {0}", contato.Cliente?.Id);
                Console.WriteLine("|- Nome: {0}", contato.Nome);
                Console.WriteLine("|- Telefone: {0}", contato.Telefone);
                Console.WriteLine("|- Parentesco: {0}", Enum.GetName(typeof(RelacaoParental), contato.TipoRelacao));
                Console.WriteLine("****************************");
            }
        }

        void CasoFuncional()
        {
            var cliente = new Cliente();
            var rnd = new Random();   
            try
            {
                cliente.Nome = "João";
                cliente.Cpf = "123456789";
                cliente.Email = "joao@gmail.com";

                cliente.AdicionarContato(new Contato()
                {
                    Id = rnd.Next(),
                    Cliente = cliente,
                    Nome = "Maria",
                    Telefone = "9999-9999",
                    TipoRelacao = RelacaoParental.Mae
                });
                cliente.AdicionarContato(new Contato()
                {
                    Id = rnd.Next(),
                    Cliente = cliente,
                    Nome = "João",
                    Telefone = "888e-9998",
                    TipoRelacao = RelacaoParental.Pai
                });
                cliente.AdicionarContato(new Contato()
                {
                    Id = rnd.Next(),
                    Cliente = cliente,
                    Nome = "Josẽ",
                    Telefone = "8811-9998",
                    TipoRelacao = RelacaoParental.Irmao
                });
                cliente.AdicionarContato(new Contato()
                {
                    Id = rnd.Next(),
                    Cliente = cliente,
                    Nome = "Carlos",
                    Telefone = "8866-9998O",
                    TipoRelacao = RelacaoParental.Outros
                });

                printCliente(cliente);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        void CasoNaoFuncional()
        {
            var cliente = new Cliente();

            try
            {
                cliente.Nome = "João";
                cliente.Cpf = "123456789";
                cliente.Email = "joao@gmail.com";

                cliente.AdicionarContato(new Contato()
                {
                    Id = 1,
                    Cliente = cliente,
                    Nome = "Maria",
                    Telefone = "9999-9999",
                    TipoRelacao = RelacaoParental.Mae
                });
                cliente.AdicionarContato(new Contato()
                {
                    Id = 2,
                    Cliente = cliente,
                    Nome = "João",
                    Telefone = "8888-9998",
                    TipoRelacao = RelacaoParental.Pai
                });

                // 
                cliente.AdicionarContato(new Contato()
                {
                    Id = 2,
                    Cliente = cliente,
                    Nome = "João",
                    Telefone = "8888-9998",
                    TipoRelacao = RelacaoParental.Pai
                });
                

                printCliente(cliente);
            }
            catch (System.Exception e)
            {
                throw new Exception(e.ToString());
            }
        }

        CasoFuncional();

        // Descomentar para testes...
        //CasoNaoFuncional

    }
}