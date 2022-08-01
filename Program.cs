using desafios;

internal class Program
{

    record Teste {
        public string Nome { get; set; }

        public Teste (string nome) {
            Nome = nome;        }

        public void Deconstruct(out string nome) {
            nome = Nome;
        }
    }

    

    private static void Main(string[] args)
    {
        #region Comentarios
        // void printCliente(Cliente cliente)
        // {


        //     Console.WriteLine("--------Dados Cliente ---------");
        //     Console.WriteLine("");
        //     Console.WriteLine("Nome: {0}", cliente.Nome);
        //     Console.WriteLine("CPF: {0}", cliente.Cpf);
        //     Console.WriteLine("Email: {0}", cliente.Email);
        //     Console.WriteLine("");

        //     Console.WriteLine("--------Lista de Contatos ---------");
        //     var listaContatos = cliente.Contatos;

        //     foreach (var contato in listaContatos)
        //     {
        //         Console.WriteLine("|- Id: {0}", contato.Id);
        //         Console.WriteLine("|- ClienteId: {0}", contato.Cliente?.Id);
        //         Console.WriteLine("|- Nome: {0}", contato.Nome);
        //         Console.WriteLine("|- Telefone: {0}", contato.Telefone);
        //         Console.WriteLine("|- Parentesco: {0}", Enum.GetName(typeof(RelacaoParental), contato.TipoRelacao));
        //         Console.WriteLine("****************************");
        //     }
        // }

        // void CasoFuncional()
        // {
        //     var cliente = new Cliente();
        //     var rnd = new Random();   
        //     try
        //     {
        //         cliente.Nome = "João";
        //         cliente.Cpf = "123456789";
        //         cliente.Email = "joao@gmail.com";

        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = rnd.Next(),
        //             Cliente = cliente,
        //             Nome = "Maria",
        //             Telefone = "9999-9999",
        //             TipoRelacao = RelacaoParental.Mae
        //         });
        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = rnd.Next(),
        //             Cliente = cliente,
        //             Nome = "João",
        //             Telefone = "888e-9998",
        //             TipoRelacao = RelacaoParental.Pai
        //         });
        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = rnd.Next(),
        //             Cliente = cliente,
        //             Nome = "Josẽ",
        //             Telefone = "8811-9998",
        //             TipoRelacao = RelacaoParental.Irmao
        //         });
        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = rnd.Next(),
        //             Cliente = cliente,
        //             Nome = "Carlos",
        //             Telefone = "8866-9998O",
        //             TipoRelacao = RelacaoParental.Outros
        //         });

        //         printCliente(cliente);
        //     }
        //     catch (System.Exception e)
        //     {
        //         throw new Exception(e.ToString());
        //     }
        // }

        // void CasoNaoFuncional()
        // {
        //     var cliente = new Cliente();

        //     try
        //     {
        //         cliente.Nome = "João";
        //         cliente.Cpf = "123456789";
        //         cliente.Email = "joao@gmail.com";

        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = 1,
        //             Cliente = cliente,
        //             Nome = "Maria",
        //             Telefone = "9999-9999",
        //             TipoRelacao = RelacaoParental.Mae
        //         });
        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = 2,
        //             Cliente = cliente,
        //             Nome = "João",
        //             Telefone = "8888-9998",
        //             TipoRelacao = RelacaoParental.Pai
        //         });

                
        //         cliente.AdicionarContato(new Contato()
        //         {
        //             Id = 2,
        //             Cliente = cliente,
        //             Nome = "João",
        //             Telefone = "8888-9998",
        //             TipoRelacao = RelacaoParental.Pai
        //         });
                

        //         printCliente(cliente);
        //     }
        //     catch (System.Exception e)
        //     {
        //         throw new Exception(e.ToString());
        //     }
        // }

        // CasoFuncional();
        

        // Descomentar para testes...
        //CasoNaoFuncional

        #endregion
    
        var objeto1 = new Teste("Filipe Carvalho");

        var objeto2  =  new Teste("Filipe Carvalho");

        // var (nome) = objeto1; 

        Console.WriteLine(objeto1 == objeto2);       
    }
}