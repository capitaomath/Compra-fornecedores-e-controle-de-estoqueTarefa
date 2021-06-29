namespace Aula14
{
    public abstract class Produto : IImprimivel
    {
        
        protected string _nome;
        protected double _preco;
        protected Fornecedor _fornecedor;


        public Fornecedor Fornecedor
        {
            get {return this._fornecedor;}
        }


        public double Preco
        {
            get { return this._preco;}
        }
        

        public string Nome
        {
            get { return this._nome; }
        }
        

        public abstract double CalculaValorTotal();
        public abstract void Imprimir();
        
    }
}