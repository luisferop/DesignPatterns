using System;

namespace prjCreational.Builder
{
    public class FishBuilder : SanduicheBuilder
    {
        private Sanduiche sanduiche = new FishBurguer();
        public override void AbrirPao()
        {
            Console.WriteLine("Abrir Pão FishBurguer");
        }

        public override void FecharPao()
        {
            Console.WriteLine("FEchar Pão FishBurguer");
        }

        public override Sanduiche GetSanduiche()
        {
            Console.WriteLine("FishBurguer Pronto!");
            return sanduiche;
        }

        public override void InserirIngredientes()
        {
            Console.WriteLine("Inserir ingredientes FishBurguer");
        }
    }
}
