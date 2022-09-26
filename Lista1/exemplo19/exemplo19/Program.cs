namespace exemplo19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("digite um numero:\n");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite um numero:\n");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("digite um numero:\n");
            c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("equilatero\n");

            }
            else if ((a != b) && (a != c) && (b != c))
            {
                Console.WriteLine("escaleno\n");
            }
            else
            {
                Console.WriteLine("isosceles\n");
            }

        }
    }
}
       
    
