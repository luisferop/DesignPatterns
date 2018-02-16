using System;

namespace prjCreational.Builder
{
    public class HamburguerBuilder : SanduicheBuilder
    {
        private Sanduiche sanduiche = new Hamburguer();

        public override void AbrirPao()
        {
            Console.WriteLine("Abrir Pão Hamburguer");
        }

        public override void FecharPao()
        {
            Console.WriteLine("Fechar Pão Hamburguer");
        }

        public override Sanduiche GetSanduiche()
        {
            Console.WriteLine("Hamburguer Pronto!");
            return sanduiche;
        }

        public override void InserirIngredientes()
        {
            Console.WriteLine("Inserir Ingredientes no Hamburguer");
        }
    }
}
