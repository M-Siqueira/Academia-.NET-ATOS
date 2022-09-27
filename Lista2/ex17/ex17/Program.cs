namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA, ladoB, ladoC;
            bool ehTriangulo;

            Console.WriteLine("lado A: \n");
            ladoA = double.Parse(Console.ReadLine());

            Console.WriteLine("lado B: \n");
            ladoB = double.Parse(Console.ReadLine());

            Console.WriteLine("lado C: \n");
            ladoC = double.Parse(Console.ReadLine());

            ehTriangulo = (ladoA <= (ladoB + ladoC) && ladoB <= (ladoC + ladoA) && ladoC <= (ladoA + ladoB));

            if (ehTriangulo == true)
            {
                Console.WriteLine("sim, é triangulo");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("equilatero \n");
                }
                else if ((ladoA != ladoB) && (ladoB != ladoC) && (ladoC != ladoA))
                {
                    Console.WriteLine("escaleno");
                }
                else
                {
                    Console.WriteLine("isosceles");
                }
            }
            else
            {
                Console.WriteLine("nao é um triangulo");
            }
        }
    }
}