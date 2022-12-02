using Microsoft.EntityFrameworkCore;

namespace entityDataFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite\n" +
                "1- para criar uma pessoa!\n" +
                "2- para alterar nome da pessoa!\n" +
                "3- para adicionar um email a uma pessoa existente!\n" +
                "4- para excluir uma pessoa!\n" +
                "5- para consultar tudo!\n" +
                "6- para consultar pelo id!\n");

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {

                
                case 1:

                    try
                    {
                        Console.WriteLine("inserir nome da pessoa");

                        Pessoa p = new Pessoa();

                        p.nome = Console.ReadLine();

                        Console.WriteLine("inserir o email");

                        string emailTemp = Console.ReadLine();

                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Emails = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("erro");
                    }
                    break;

                case 2:
                    try
                    {

                        Console.WriteLine("informe o id da pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);

                        Console.WriteLine("informe o nome correto");
                        pAlt.nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error2");
                    }



                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("informe id da pessoa ");
                        int idEm = int.Parse(Console.ReadLine());

                        Pessoa pEm = contexto.Pessoas.Find(idEm);

                        Console.WriteLine("novo email da pessoa");
                        string emailTemp = Console.ReadLine();

                        pEm.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Emails = emailTemp
                            }
                        };

                        contexto.Pessoas.Update(pEm);
                        contexto.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error3");
                    }
                    break;

                case 4:

                    try
                    {
                        Console.WriteLine("informe o id da pessoa.");

                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Find(id);

                        Console.WriteLine("confirma a exclusao de " + p.nome + " ?");
                        Console.WriteLine("e todos seus emails.");

                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.Emails);
                        }
                        Console.WriteLine("1 para sim, outra para nao..");

                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                            Console.WriteLine(p.nome + "excluido com sucesso!");
                        }
                        else
                        {

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error4");
                    }




                    break;
                case 5:


                    try
                    {
                        List<Pessoa> lista = new List<Pessoa>();

                        //LINK

                        lista = (from Pessoa p in contexto.Pessoas
                                 select p).Include(e => e.Emails).ToList<Pessoa>();

                        foreach (Pessoa item in lista)
                        {
                            Console.WriteLine(item.nome);
                            foreach (Email email in item.Emails)
                            {
                                Console.WriteLine(email.Emails);
                            }
                            Console.WriteLine();
                        }



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("error5");
                    }

                    break;
                case 6:
                    try
                    {
                        Console.WriteLine("informe o id da pessoa...");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails)
                            .FirstOrDefault(Pessoa => Pessoa.Id== id);

                        Console.WriteLine("nome " + p.nome);

                        if (p.Emails != null)
                        {
                            foreach (Email email in p.Emails)
                            {
                                Console.WriteLine("\t" + email.Emails);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        throw;
                    }




                    break;

            }
        }
    }
}