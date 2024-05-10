using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pokedex pokedex = new pokedex();
            int resp = 100;
            while (resp!= 0)
            {
                resp = Menu();
                if (resp == 1) 
                {
                    pokedex.ListarPokemons();
                }
                Console.ReadKey();
                Console.Clear();
            }
            

        }

        static int Menu() 
        {
            Console.WriteLine("pokedex --- Agenda pokemon");
            Console.WriteLine("0 - sair da pokedex");
            Console.WriteLine("1 - Listar todos pokemons");
            Console.Write("o que deseja fazer?");
            int resp = Convert.ToInt32(Console.ReadLine());
            return resp;
        }
    }
}
