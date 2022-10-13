using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronico
{
    class Televisao : Eletronico
    {
        public override void Ligar()
        {
            //throw new NotImplementedException();
            Console.WriteLine("ligando....TV");
            //_ligado = true;
            this.Ligado = true;
        }
    }
}
