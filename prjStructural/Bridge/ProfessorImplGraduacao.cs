using System;

namespace prjStructural.Bridge
{
    public class ProfessorImplGraduacao : Implementador
    {
        public override void OpImpl()
        {
            Console.WriteLine("Implementação Prof. Gradução");
            Console.WriteLine("Say GoodBye!");
        }
    }
}
