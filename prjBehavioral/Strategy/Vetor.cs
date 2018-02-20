using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjBehavioral.Strategy
{
    public class Vetor
    {
        private AlgoritmoOrdenacao _algoritmoOrdenacao;
        public Vetor(AlgoritmoOrdenacao algoritmoOrdenacao)
        {
            _algoritmoOrdenacao = algoritmoOrdenacao;
        }

        public AlgoritmoOrdenacao AlgoritmoOrdenacao
        {
            set { _algoritmoOrdenacao = value; }
        }

        public void Ordenar()
        {
            _algoritmoOrdenacao.Sort();
        }
    }
}
