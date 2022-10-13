using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronico
{
    class Celular : Eletronico
    {

        public override void Ligar()
        {
            //throw new NotImplementedException();

            Console.WriteLine("ligando....SMARTPHONE");

            this.Ligado = true;
        }
    }
}
