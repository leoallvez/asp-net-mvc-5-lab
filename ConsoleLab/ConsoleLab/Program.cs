using ConsoleLab.Class;
using ConsoleLab.Class.Animais;
using System;
using System.Linq;

namespace ConsoleLab
{
    class Program
    {

        public static void Main()
        {

            var macho = new Gato();
            var femea = new Gato();

            var filhote = (new Gato()).Cruzar(macho, femea);

        }


    }
}
