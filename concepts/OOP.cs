namespace Concepts {

    record Log(string mensagem, int km);
    struct Teste {
        public string Nome { get; set; }
        public int Idade { get; set; }

        void start() {

        }
    }

    

    class Animal {


        void Andar() {
            var log = new Log("Andou", 20);          
              
        }
    }

    class Boi : Animal {

    }




}