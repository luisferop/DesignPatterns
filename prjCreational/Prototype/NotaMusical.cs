using System;

namespace prjCreational.Prototype
{
    public abstract class NotaMusical : ICloneable
    {
        public object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            return (NotaMusical)clone;
        }
        public abstract void Desenhar();
    }
}
