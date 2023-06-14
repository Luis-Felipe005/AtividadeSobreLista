using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08ListaReticao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reptições (loop)

            while ( 1 > 0)
            {
                Console.WriteLine("Olá");

            }
           

        }

       
        void Atividade.add() 
        {

            List<string> nomes = new List<string>();




            nomes.Add("gabriel");
            nomes.Add("Lucas");
            nomes.Add("Bia");


            Console.WriteLine("A primeira posição é:" + nomes[0]);
            Console.WriteLine("A primeira posição é:" + nomes[1]);
            Console.WriteLine("A primeira posição é:" + nomes[2]);

            nomes.Remove("Lucas");
            nomes.RemoveAt(0);

            int quantidade = nomes.Count;

            Console.WriteLine($"existem {quantidade} itens dentro da lista");



            Console.ReadKey();








            // --------------- LISTAS ------------------
           // List<string> nomes = new List<string>();

           // nomes.Add("Gabriel");
          //  nomes.Add("Luis");
          //  nomes.Add("Bia");


           // Console.WriteLine("Cadastro de usuário:");
           // Console.WriteLine("1 - Cadastro:");
          //  Console.WriteLine("2 - Buscar");

          //  Console.WriteLine("Digite uma opção:");
          // numero = int.Parse(Console.ReadLine());

           // int numero;



           // if (numero == 2)
         //   {

            //    Console.WriteLine("Digite a posição que quer buscar:");
          //      numero = int.Parse(Console.ReadLine());
          //  }



          //  else (numero > 2)
                    {

            //    Console.WriteLine("Número inválido");
         //   }

          //  if (numero == 1)
          //  {

             //   Console.WriteLine("Digite o nome que deseja cadastrar:");
            //    Console.ReadLine();
           // }












            Console.ReadKey();


















        }


        void Arrays()
        {

            string[] nomes = new string[3];
            int[] idades = { 16, 20, 18, 19, 31, 25 };

            nomes[0] = "Conrado";
            nomes[2] = "Luis Felipe";
            nomes[1] = "Victor";
            nomes[3] = "Pedro";
            nomes[4] = "Maria";

            Console.WriteLine("O nome da primeira posição é" + nomes[0]);
            Console.WriteLine("O nome da primeira posição é" + nomes[1]);
            Console.WriteLine("O nome da primeira posição é" + nomes[2]);

            Console.ReadKey();



        }



    }


}
