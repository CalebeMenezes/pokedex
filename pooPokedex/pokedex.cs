using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooPokedex
{
    public class pokedex
    {

        public pokedex() 
        {
            this.InicializaLista();  
        }

		private List<Pokes> pokemons;

		public List<Pokes> Pokemons
		{
			get { return pokemons; }	
		}

		private void InicializaLista() 
		{
			//Instanciar a lista
			this.pokemons = new List<Pokes>();
			Pokes p = new Pokes("pikachu", " descriçao");
			this.pokemons.Add(p);
			p = new Pokes("squirtle", " desriçao");
			this.pokemons.Add(p);

			//inserir 10 pokes
			p = new Pokes("cindaquil", "descriçao");
			this.pokemons.Add(p);
            p = new Pokes("mew", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("mewtwo", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("eevee", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("umbreom", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("glaceon", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("rayquaza", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("lunala", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("charizard", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("totodile", "descriçao");
            this.pokemons.Add(p);
            p = new Pokes("beetree", "descriçao");
            this.pokemons.Add(p);


        }

        public void ListarPokemons() 
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                this.pokemons[i].ExibirDadosPoke(); 
                //Pokes p = this.pokemons[i]; // alternativa
                //p.ExibirDadosPoke();
            }
        }

	}
}
