using System;

namespace ConsoleLab.Class.Animais
{
    public abstract class Mamifero<T> where T : Mamifero<T>
    {
        public T Pai { get; set; }
        public T Mae { get; set; }
        public decimal Peso { get; set; }

        public T Cruzar(T macho, T femea) 
        {
            //Criar uma instancia de Gererics.
            var filhote = Activator.CreateInstance<T>();
            filhote.Pai = macho;
            filhote.Mae = femea;

            return filhote;
        }
    }
}
