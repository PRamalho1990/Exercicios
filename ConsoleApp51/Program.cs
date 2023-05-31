using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            //          tipo nome     atribuição



            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'm';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos");
            Console.WriteLine();
            Console.WriteLine(produto1 + " Cujo o preço é " + preco1.ToString("f2"),CultureInfo.InvariantCulture + " Reais");
            Console.WriteLine(produto2 + " Cujo o preço é  $ " + preco2.ToString("f2"),CultureInfo.InvariantCulture + "Reais");
            Console.WriteLine();
            Console.WriteLine("Registro");
            Console.WriteLine(idade + " de idade, Código " + codigo + " Genero : " + genero );
            Console.WriteLine();
            Console.WriteLine("Medida de Casas decimais : " + medida);
            Console.WriteLine("Medida de Casas decimais : " + medida.ToString("f3"),CultureInfo.InvariantCulture);
            Console.WriteLine("Medida de Casas decimais : " + medida.ToString("f3",CultureInfo.InvariantCulture));


            Console.ReadKey();





        }
    }
}
