namespace tryCatchExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            try
            {
                Console.WriteLine("informe o x:\n");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("valor de x é: " + x);
                double y = 50 / x;
                Console.WriteLine("valor de 50 dividido por x é: " + y);
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("divisao por zero...");
            }
            catch (FormatException ex)
            {

                Console.WriteLine("erro de formato...");
            }
            catch (OverflowException ex)
            {

                Console.WriteLine("erro, numero muito grande...");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //usado para fechar conexoes com banco.
                //fecha arquivo.
                //opcional mas usual.
            }

            

        }
    }
}