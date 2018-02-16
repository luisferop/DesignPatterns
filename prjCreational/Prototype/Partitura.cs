using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjCreational.Prototype
{
    public class Partitura
    {

        private static Dictionary<string, NotaMusical> notaMapa = new Dictionary<string, NotaMusical>();

        public static void CarregarNotas()
        {
            Do notaDo = new Do();
            notaMapa.Add("Do", notaDo);

            Re notaRe = new Re();
            notaMapa.Add("Re", notaRe);

            Mi notaMi = new Mi();
            notaMapa.Add("Mi", notaMi);

            Fa notaFa = new Fa();
            notaMapa.Add("Fa", notaFa);

            Sol notaSol = new Sol();
            notaMapa.Add("Sol", notaSol);

            La notaLa = new La();
            notaMapa.Add("La", notaLa);

            Si notaSi = new Si();
            notaMapa.Add("Si", notaSi);

        }
        public static NotaMusical GetNota(string nome)
        {
            NotaMusical nota = notaMapa[nome];
            return (NotaMusical)nota.Clone();
        }
    }
}
