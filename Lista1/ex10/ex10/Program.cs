namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)

            //em andamento
        {
            double sac, sobraA, sobraB, sobraC, sobraD, sobraE;
            int a, b, c, d, e;

            Console.WriteLine("digite o valor a ser sacado: \n");
            sac = double.Parse(Console.ReadLine());
            Console.WriteLine("\n \n");

          
            a = (int)sac / 50;
            sobraA = sac - (a * 50);

            b = (int)sac / 20;
            sobraB = sac - (b * 20);

            c = (int)sac / 10;
            sobraC = sac - (c * 10);

            d = (int)sac / 5;
            sobraD = sac - (d * 5);

            e = (int)sac / 1;
            sobraE = sac - (e * 1);
          



            Console.WriteLine(a +" notas");
            Console.WriteLine(b + " notas");
            Console.WriteLine(c + " notas");
            Console.WriteLine(d + " notas");
            Console.WriteLine(e + " notas");

            Console.WriteLine("\n");

            Console.WriteLine(a * 50 + " numero de notas x valor da nota");
            Console.WriteLine(b * 20 + " numero de notas x valor da nota");
            Console.WriteLine(c * 10 + " numero de notas x valor da nota");
            Console.WriteLine(d * 5 + " numero de notas x valor da nota");
            Console.WriteLine(e * 1 + " numero de notas x valor da nota");

            Console.WriteLine("\n \n");

            Console.WriteLine(sobraA+" saldo restante");
            Console.WriteLine(sobraB + " saldo restante");
            Console.WriteLine(sobraC + " saldo restante");
            Console.WriteLine(sobraD + " saldo restante");
            Console.WriteLine(sobraE + " saldo restante");


            Console.WriteLine();




            }

        }



    }