namespace exemplo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,resultado;
            int op;

            Console.WriteLine("digite 2 numeros inteiros");
            num1 = Double.Parse(Console.ReadLine());
            num2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nescolha a operacao:\n1.soma\n2.subtracao\n3.multiplicacao\n4.divisao\n5.potencia");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine(resultado);
            }else if (op == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine(resultado);
            }
            else if (op == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine(resultado);
            }
            else if (op == 4)
            {
                resultado = num1 / num2;
                Console.WriteLine(resultado);
            }
            else if (op == 5)
            {
                //resultado = num1  num2;
                //Console.WriteLine(resultado);
            }
            
        }
    }
}
