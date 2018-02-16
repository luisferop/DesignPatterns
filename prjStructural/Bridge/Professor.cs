namespace prjStructural.Bridge
{
    public abstract class Professor
    {
        protected Implementador _implementador = new ProfessorImplGraduacao();
        protected Professor(Implementador implementador)
        {
            _implementador = implementador;
        }

        public abstract void Operacao();
    }
}
