namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d,rA,rB;
            Console.WriteLine("insira o numero de horas aula do professor A ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor por hora do professor A ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("insira o numero de horas aula do professor A ");
            c = float.Parse(Console.ReadLine());

            Console.WriteLine("insira o valor por hora do professor A ");
            d = float.Parse(Console.ReadLine());


            rA = a * b;
            rB = c * d;

            if (rA > rB)
            {
                Console.WriteLine("professor A tem salario maior. "+rA+" R$");
            }
            else if(rB > rA)
            {
                Console.WriteLine("professor B tem salario maior. " + rB + " R$");
            }
            else
            {
                Console.WriteLine("salarios iguais");
            }


        }
    }
}