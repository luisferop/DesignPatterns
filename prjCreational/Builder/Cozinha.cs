namespace prjCreational.Builder
{
    public class Cozinha
    {
        public void FazerSanduiche(SanduicheBuilder builder)
        {
            builder.AbrirPao();
            builder.InserirIngredientes();
            builder.FecharPao();
        }
    }
}
