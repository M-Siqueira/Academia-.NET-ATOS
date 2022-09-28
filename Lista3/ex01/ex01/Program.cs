namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, par = 0;

            
            while (num >= 0)
            {
                Console.WriteLine("digite um numero valido. ");
                num = int.Parse(Console.ReadLine());


                if (num < 0 || (num  % 2 != 0))
                {

                    Console.WriteLine("numero invalido");4
                    Console.WriteLine("digite um numero valido");
                    num = int.Parse(Console.ReadLine());

                }
                if ((num > 0) && (num % 2 == 0))
                {
                    //conta numero de pares
                    par++;
                    Console.WriteLine("valido");

                }
            }
        }






        //Console.WriteLine(num + " posição " + i + "  é par");



        //Console.WriteLine(cont + "numeros pares encontrados");
    }
}
