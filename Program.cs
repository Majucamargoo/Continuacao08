using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListasERepeticoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();


            nomes.Add(" Kennedy");
            nomes.Add(" Dany");
            nomes.Add(" Eduardo");
            nomes.Add(" Mirela");
            nomes.Add(" Maju");
            nomes.Add(" Bruno");


            int quantidade = nomes.Count;
            int contador = 0;
            while (contador < quantidade )
            {
                Console.WriteLine(" Nome:" + nomes[contador] );
                contador += 1;


                
            }
            Console.ReadKey();




        }
        void loop()
        {
            // laço de repetição (LOOP)

            int contador = 0;



            while (contador < 10)
            {
                Console.WriteLine(" OLÁ! ");
                contador = contador + 1;
            }




            Console.ReadKey();

        }





        void Lista()
        {



            //LISTAS => Mesmo que o Array, porém com tamanhos automático
            // ADD (item) => Adiciona item novo na lista
            // REMOVE (item) 


            List<string> nomes = new List<string>();

            nomes.Add("Jonatas");
            nomes.Add("Natanael");
            nomes.Add("Bruno");

            Console.WriteLine("O Primeiro nome é " + nomes[0]);
            Console.WriteLine("O Segundo nome é " + nomes[1]);
            Console.WriteLine("O Terceiro nome é " + nomes[2]);

            Console.WriteLine("Digite seu nome:");
            nomes.Add(Console.ReadLine());

            nomes.RemoveAt(3);
            nomes.Remove("Natanael");


            int quantidade = nomes.Count;
            Console.WriteLine($"Existem {quantidade} usuários existem cadastrados");






            Console.ReadKey();
        }









        void arrays() { 
        
        
            // ARREY -> Conjunto de Dados (VETOR)

            string[] nomes = new string[3];
            int[] idades = { 19, 21, 18 };

            nomes[0] = "Maju";
            nomes[1] = "Dany";
            nomes[2] = "Kennedy";

            Console.WriteLine("O nome da Primeira posição é " + nomes[0]);
            Console.WriteLine("O nome da Segunda posição é " + nomes[1]);
            Console.WriteLine("O nome da Terceira posição é " + nomes[2]);



            Console.ReadKey();
        }

    
    }

}
