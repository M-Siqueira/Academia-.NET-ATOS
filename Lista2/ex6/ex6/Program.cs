namespace ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float peso, altura,IMC;

            Console.WriteLine("seu nome: \n");
            nome = (Console.ReadLine());

            //tranformando em maiusculo  o conteudo da variavel 
            string Unome = nome.ToUpper();

            Console.WriteLine("seu peso: \n");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("sua altura: \n");
            altura = float.Parse(Console.ReadLine());

            IMC = (peso / (altura * altura));

            Console.WriteLine("\n");
            Console.WriteLine("sr: "+Unome);
            Console.WriteLine("seu indice: "+IMC);

            if(IMC < 18 )
            {
                Console.WriteLine("baixo peso");
            }
            if (IMC > 18 && IMC < 25)
            {
                Console.WriteLine("peso normal");
            }
            if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine("sobrepeso");
            }
            if (IMC > 30 && IMC < 35)
            {
                Console.WriteLine("obesidade");
            }
            if (IMC > 35)
            {
                Console.WriteLine("obesidade grau serio");
            }


        }
    }
}