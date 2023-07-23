namespace AplicacaoConsole.Interface
{
    interface IAnimalInterface
    {
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimalInterface { 
        public string Nome { get; set; }   
        public string NomeDono { get; set; }    
        public string Especie { get; set;}

        void IAnimalInterface.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimalInterface.Dono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }

        void IAnimalInterface.Especie(string especie)
        {
            this.Especie = especie;
        }

    } 
}
