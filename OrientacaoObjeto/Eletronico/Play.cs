using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletronico
{
    class Play : Eletronico
    {
        public override void Ligar()
        {
            //throw new NotImplementedException();
            Console.WriteLine("ligando....play");
            this.Ligado = true;
        }
    }
}
