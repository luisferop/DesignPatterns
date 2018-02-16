using prjCreational.Prototype;
using System;

namespace prjCreational
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Singleton
            //Singleton singleton = Singleton.GetInstance();
            #endregion

            #region FactoryMethod
            //Empresa viacaoUrbana = new EmpresaOnibusUrbano();
            //Passagem pUrbana = viacaoUrbana.EmitirPassagem("Belo Horizonte", "Betim", DateTime.Now.AddDays(3));
            //pUrbana.ExibirDetalhes();
            //Empresa viacaoInterEstadual = new EmpresaOnibusInterEstadual();
            //Passagem pInterEstadual = viacaoInterEstadual.EmitirPassagem("São Paulo", "Curitiba", DateTime.Now.AddDays(10));
            //pInterEstadual.ExibirDetalhes();
            #endregion

            #region AbstractFactory
            //EmpresaOnibus empresaOnibusUrbano = new ConcreteEmpresaOnibus();
            //PassagemOnibusUrbano passagemOnibusUrbano = empresaOnibusUrbano.EmitirPassagemOnibusUrbano("Belo Horizonte", "Betim", DateTime.Now.AddDays(3));
            //passagemOnibusUrbano.ExibirDetalhes();
            //EmpresaOnibus empresaOnibusInterEstadual = new ConcreteEmpresaOnibus();
            //PassagemOnibusInterEstadual passagemOnibusInterEstadual = empresaOnibusInterEstadual.EmitirPassagemOnibusInterEstadual("São Paulo", "Curitiba", DateTime.Now.AddDays(10));
            //passagemOnibusInterEstadual.ExibirDetalhes();
            #endregion

            #region Builder
            //Cozinha cozinha = new Cozinha();
            //SanduicheBuilder b1 = new HamburguerBuilder();
            ////SanduicheBuilder b2 = new FishBuilder();
            //cozinha.FazerSanduiche(b1);
            //b1.GetSanduiche();
            #endregion

            #region Prototype
            Partitura.CarregarNotas();

            //Compor a canção
            Partitura.GetNota("Do").Desenhar();
            Partitura.GetNota("Re").Desenhar();
            Partitura.GetNota("Mi").Desenhar();
            Partitura.GetNota("Fa").Desenhar();
            Partitura.GetNota("Fa").Desenhar();
            Partitura.GetNota("Fa").Desenhar();
            Partitura.GetNota("Do").Desenhar();
            Partitura.GetNota("Re").Desenhar();
            Partitura.GetNota("Do").Desenhar();
            Partitura.GetNota("Re").Desenhar();
            Partitura.GetNota("Re").Desenhar();
            Partitura.GetNota("Re").Desenhar();
            #endregion
            Console.ReadLine();
        }
    }
}
