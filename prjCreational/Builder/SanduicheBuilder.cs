namespace prjCreational.Builder
{
    public abstract class SanduicheBuilder
    {
        public abstract void AbrirPao();
        public abstract void InserirIngredientes();
        public abstract void FecharPao();
        public abstract Sanduiche GetSanduiche();
    }
}
