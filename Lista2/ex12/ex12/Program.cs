namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cod;
            double VtotalHoras,Vtotal,saldo, horas,horaT = 10.00, max, extra;

            Console.WriteLine("codigo: ");
            cod = int.Parse(Console.ReadLine());

            Console.WriteLine("numero horas: ");
            horas = double.Parse(Console.ReadLine());

            Vtotal = horaT * horas;

            VtotalHoras = 50 * horaT;
            
            max = 50;

            extra = horas - max;

            saldo = ((extra * 20) + VtotalHoras);

            if (horas <= 50)
            {
                Console.WriteLine("salario total h trabalhadas: " + Vtotal);
            }
            else
            {
                Console.WriteLine("salario total h trabalhadas: " + saldo);
            }


        }
    }
}