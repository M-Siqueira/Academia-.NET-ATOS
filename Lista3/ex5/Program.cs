namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string candidato1, candidato2;
            int i,maior,JOAO = 0, ZECA = 0, BRANCO = 0,NULO = 0, eleitor = 0;

            do
            {
                Console.WriteLine("digite o nome do seu candidato: \n");

                candidato1 = Console.ReadLine();
                candidato2 = candidato1.ToUpper();//transformando em maiusculo para comparar.

                eleitor++;

                if ((candidato2 != "JOAO") && (candidato2 != "ZECA") && (candidato2 != "BRANCO") && (candidato2 != "FIM"))
                {
                    NULO++;
                }
                if (candidato2 == "JOAO")
                {
                    JOAO++;
                }
                if (candidato2 == "ZECA")
                {
                    ZECA++;
                }
                if (candidato2 == "BRANCO")
                {
                    BRANCO++;
                }
            
            } while (candidato2 != "FIM");


            if ((JOAO > ZECA) && (JOAO > NULO) && (JOAO > BRANCO))
            {
                Console.WriteLine("vencedor é Joao");
            }
            if ((ZECA > JOAO) && (ZECA > NULO) && (ZECA > BRANCO))
            {
                Console.WriteLine("vencedor é Zeca");
            }
            if ((BRANCO > JOAO) && (BRANCO > NULO) && (BRANCO > ZECA))
            {
                Console.WriteLine("branco teve mais votos");
            }
            if ((NULO > JOAO) && (NULO > ZECA) && (NULO > BRANCO))
            {
                Console.WriteLine("nulo teve mais votos");
            }


            Console.WriteLine("numero de eleitores: "+(eleitor -1));
            Console.WriteLine("candidato Joao teve: \n" + JOAO + " votos!");
            Console.WriteLine("candidato zeca teve: \n" + ZECA + " votos!");
            Console.WriteLine("BRANCO teve: \n" + BRANCO + " votos!");
            Console.WriteLine("NULO teve: \n" + NULO + " votos!");

            //

        }
    }
}