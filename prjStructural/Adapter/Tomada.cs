using System;

namespace prjStructural.Adapter
{
    /// <summary>
    /// Target
    /// </summary>
    /// <typeparam name="P"></typeparam>
    public abstract class Tomada<P>
    {
        public abstract String Conecta(P plug);

        public abstract String GetNomeRede();
    }
}
