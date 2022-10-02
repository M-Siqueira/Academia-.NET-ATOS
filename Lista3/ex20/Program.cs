namespace ex20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sexo, olhos, cabelos;
            int idade, maiorIdade = 0,qtdF = 0,qtdFid = 0;

            while (true)
            {
                Console.WriteLine("idade?\n");
                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                {
                    break;
                }
                Console.WriteLine("sexo? (M ou F)\n");
                sexo = Console.ReadLine();
                Console.WriteLine("cor dos olhos? (azuis A, verdes V, castanho C)\n");
                olhos = Console.ReadLine();
                Console.WriteLine("cor dos cabelos? (louro L, castanho C, preto P)\n");
                cabelos = Console.ReadLine();

                if ((sexo == "F") && (idade > 17 && idade < 36)&&(olhos == "V")&&(cabelos == "L"))
                {
                    qtdFid++;
                }

                while (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }


            }
            Console.WriteLine("maior idade dos habitantes: "+maiorIdade);
            Console.WriteLine("mulheres entre 18 e 35: "+qtdFid);





        }
    }
}