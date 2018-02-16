using prjStructural.Adapter;
using prjStructural.Bridge;
using prjStructural.Composite;
using prjStructural.Decorator;
using prjStructural.Proxy;
using prjStructural.Facade;
using System;
using prjStructural.Flyweight;

namespace prjStructural
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Bridge
            //Professor grad = new ProfessorGraduacao(new ProfessorImplGraduacao());
            //grad.Operacao();

            //Professor posGrad = new ProfessorPosGraduacao(new ProfessorImplPosGraduacao());
            //posGrad.Operacao();
            #endregion

            #region Adapter
            ////Target
            //TomadaBrasileira tomadaBras = new TomadaBrasileira();

            ////Adaptado
            //PlugAmericano plugEUA = new PlugAmericano();

            //AdapterEUAtoBrasil tomadaModificada = new AdapterEUAtoBrasil();
            //String s = tomadaModificada.Conecta(plugEUA);

            //Console.WriteLine(s);
            #endregion

            #region Proxy
            //Image image1 = new ProxyImage("HiRes_10MB_Photo1");
            //Image image2 = new ProxyImage("HiRes_10MB_Photo2");

            //image1.DisplayImage();
            //image2.DisplayImage();

            //image1.DisplayImage();
            #endregion

            #region Decorator
            //Arvore a = new ArvoreNatal();

            //a = new Estrela(a);
            //a = new Bola(a);
            //a = new Bola(a);
            //a = new Bola(a);
            //a = new Bola(a);
            //a = new Bola(a);
            //a = new PiscaPisca(a);

            //a.ShowEnfeites();
            #endregion

            #region Composite
            ////Cria programadores (folhas)
            //Programador pEstagiario = new Programador("José", 900);
            //Programador pJunior = new Programador("Pedro", 2900);
            //Programador pSenior = new Programador("Ricardo", 3900);

            ////Gerentes
            //Gerente g3 = new Gerente("João", 15000);
            //Gerente g2 = new Gerente("Maria", 10000);
            //Gerente g1 = new Gerente("Carlos", 5000);

            ////Montar a estrutura em árvore

            ////Carlos superviosiona os programadores José e Pedro
            //g1.Add(pEstagiario);
            //g1.Add(pJunior);

            ////Maria superviosiona o programador Ricardo
            //g2.Add(pSenior);

            ////João é raiz da estrutura em árvore
            //g3.Add(g1);
            //g3.Add(g2);

            //g3.Print();
            #endregion

            #region Facade
            //Facade.Facade facade = new Facade.Facade();
            //facade.MetodoA();
            //Console.WriteLine();
            //facade.MetodoB();
            #endregion

            #region FlyWeitght

            Figura f = FiguraFactory.getFigura("linha");
            f.Desenha("amarela");

            f = FiguraFactory.getFigura("oval não preenchida");
            f.Desenha("vermelha");
            #endregion
            Console.ReadLine();
        }
    }
}
