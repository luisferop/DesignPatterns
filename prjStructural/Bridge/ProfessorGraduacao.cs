using System;

namespace prjStructural.Bridge
{
    public class ProfessorGraduacao : Professor
    {
        public ProfessorGraduacao(Implementador implementador) : base(implementador)
        {
        }

        public override void Operacao()
        {
            Console.WriteLine("Olá professor de graduação!");
            _implementador.OpImpl();
        }
    }
}
