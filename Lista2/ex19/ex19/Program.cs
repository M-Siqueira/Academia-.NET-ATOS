namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, x = 0, y = 0, z = 0;

            Console.WriteLine("valor A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("valor B");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("valor C");
            c = int.Parse(Console.ReadLine());


            if (a > b && a > c)
            {
                x = a;

                if (b > c)
                {
                    y = b;
                    z = c;
                }
                if(c > b)
                {
                    y = c;
                    z = b;
                }


            }
            if (b > c && b > a)
            {
                x = b;

                if (a > c)
                {
                    y = a;
                    z = c;
                }
                if(c > a)
                {
                    y = c;
                    z = a;
                }


            }
            if (c > b && c > a)
            {
                x = c;

                if (a > b)
                {
                    y = a;
                    z = c;
                }
                if(b > a)
                {
                    y = b;
                    z = a;
                }


            }
            Console.WriteLine("maior para menor: \n");
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("\n");

            Console.WriteLine("menor para maior: \n");

            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(x);

        }
    }
}