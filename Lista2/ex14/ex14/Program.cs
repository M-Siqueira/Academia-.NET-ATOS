namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //levando em consideração mb/s e tamanho do arqiovo em mb (sem conversao de 8 bits)

            //para ter os 200megabits/s em megabyte/s divimos o 200/8 = 25MB/s


            double MB, vel, velMB, tempoEspera;

            Console.WriteLine("quantos MB tem o arquivo? \n");
            MB = double.Parse(Console.ReadLine());

            Console.WriteLine("qual velocidade da internet \n");
            vel = double.Parse(Console.ReadLine());

            velMB = vel / 8;

            tempoEspera = MB / velMB;

            Console.WriteLine("tempo de espera de download: "+TimeSpan.FromMinutes(tempoEspera/60));
        }
    }
}