namespace prjStructural.Bridge
{
    public class ProfessorPosGraduacao : Professor
    {
        public ProfessorPosGraduacao(Implementador implementador) : base(implementador)
        {
        }

        public override void Operacao()
        {
            _implementador.OpImpl();
        }
    }
}
