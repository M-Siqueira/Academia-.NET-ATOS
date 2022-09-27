namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a,b,c;

            Console.WriteLine("valor A");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("valor B");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("valor C");
            c = double.Parse(Console.ReadLine());


            if(a > b && a > c){

                Console.WriteLine("maior deles: " + a);

            }if (b > a && b > c)
            {
                Console.WriteLine("maior deles: " + b);
            }
            if (c >a && c > b)
            {
                Console.WriteLine("maior deles: "+c);
            }



        }
    }
}