namespace exemplo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic1 = new Dictionary<int, string>();

            dic1.Add(1, "maria");
            dic1.Add(2, "Paulo");
            dic1.Add(3, "Pedro");

            foreach (KeyValuePair<int, string> item in dic1)
            {
               Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(dic1[1]);
            Console.WriteLine(dic1[3]);
            Console.WriteLine(dic1[2]);


            dic1.Remove(1);

            Console.WriteLine(dic1.ContainsKey(1));// retorna true
            Console.WriteLine(dic1.ContainsKey(4));// retorna false

            Console.WriteLine(dic1.ContainsValue("maria"));// retorna true


                if (dic1.TryGetValue(4, out string s))
                {
                   Console.WriteLine(s);
                }
                else
                {
                   Console.WriteLine("erro");
                }
            
            foreach(KeyValuePair<int, string> kvp in dic1)
            {
               Console.WriteLine(kvp);
            }

            //criando dic ordenado

            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();
            //add strings
            dic2.Add("zebra", 5);
            dic2.Add("cao", 2);
            dic2.Add("gato", 9);
            dic2.Add("pardal", 4);
            dic2.Add("ca", 100);
            dic2.Add("ze", 50);




            if (dic2.ContainsKey("gato"))
            {
                Console.WriteLine("tem gato");
            }
            if (dic2.ContainsKey("zebra"))
            {
                Console.WriteLine("tem zebra");
            }



            Console.WriteLine("\n");
            int v;


            if (dic2.TryGetValue("ca", out v))
            {
                Console.WriteLine(" indice de ca: " +v);
                Console.WriteLine("\n");
            }foreach (KeyValuePair<string,int> p in dic2)
            {
                Console.WriteLine(p.Key+" "+ p.Value);
            }

        }

    }
}