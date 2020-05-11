using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteForeachConsole.Model;

namespace TesteForeachConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dados> data = new List<Dados>();

            Dados dado = new Dados("Dante", "dante.s@uni9.edu.br");
            Dados dado1 = new Dados("Maria", "dante.s@uni9.edu.br");
            Dados dado2 = new Dados("Alison", "dante.s@uni9.edu.br");
            Dados dado3 = new Dados("José", "dante.s@uni9.edu.br");

            data.Add(dado);
            data.Add(dado1);
            data.Add(dado2);
            data.Add(dado3);
            data.Add(new Dados("Marcos", "dante.s@uni9.edu.br"));

            var x = data.Count();

            Console.WriteLine(x);


            // acessando os elementos da Collection um a um
            foreach (Dados d in data)
            {
                Console.WriteLine(d.ToString());
            }

            // para compilar, usar Ctrl+F5

        }
    }
}
