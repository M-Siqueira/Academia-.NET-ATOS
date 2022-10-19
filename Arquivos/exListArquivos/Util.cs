using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exListArquivos
{
    internal class Util
    {

        public static void gravarArquivo(string frase, string nomeRaquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeRaquivo, append:true); // abre o arquivo para escrita.

            string fraseFim = frase.ToUpper();

            escritor.Write(fraseFim);

            escritor.Flush();// usar flush seprte como boa pratica para manter dads salvos;

            escritor.Close();
        }




    }
}
