using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStructural.Flyweight
{
    public class FiguraFactory
    {
        private static readonly Dictionary<String, Figura> figuras = new Dictionary<String, Figura>();

        public static Figura getFigura(String nome)
        {
            Figura fig;
            try
            {
                fig = figuras[nome];
            }
            catch (Exception)
            {

                fig = null;
            }
            

            if (fig == null)
            {
                if (nome.Equals("oval preenchida"))
                {
                    fig = new Oval(true);
                }
                else if (nome.Equals("oval não preenchida"))
                {
                    fig = new Oval(false);
                }
                else if (nome.Equals("linha"))
                {
                    fig = new Linha();
                }

                figuras.Add(nome, fig);
            }
            return fig;
        }
    }
}
