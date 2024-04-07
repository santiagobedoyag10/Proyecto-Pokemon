using PokemonP.src.interfaces;
using PokemonP.src.clases;

        Console.WriteLine("Ingresa el Nombre del Pokemon #1");
        string nomp1= Console.ReadLine();
        Console.WriteLine("Ingresa el Tipo del Pokemon #1");
        string tipop1= Console.ReadLine();
        Console.WriteLine("Ingresa el Nombre del Pokemon #2");
        string nomp2= Console.ReadLine();
        Console.WriteLine("Ingresa el Tipo del Pokemon #2");
        string tipop2= Console.ReadLine();
        Pokemon pokemon1 = new Pokemon(nomp1, tipop1);
        Pokemon pokemon2 = new Pokemon(nomp2, tipop2);


        for (int i = 0; i < 3; i++)
        {
            int ataque1 = pokemon1.atacarpokemon();
            int defensa2 = pokemon2.defenderpokemon();
            int ataque2 = pokemon2.atacarpokemon();
            int defensa1 = pokemon1.defenderpokemon();
            Console.WriteLine("TURNO #" + (1+i));

            if (defensa2 >= ataque1){
                pokemon1.reducirsalud(defensa2 - ataque1);
                Console.WriteLine("La Defensa de " + pokemon2.nombrepokemon() + " Reduce la Salud un " +  (defensa2 - ataque1)+ " de "+pokemon1.nombrepokemon() + " y Deja su Salud en " + pokemon1.saludpokemon());
            }
            else{
                pokemon2.reducirsalud(ataque1 - defensa2);
                Console.WriteLine("El Ataque de " + pokemon1.nombrepokemon() + " Reduce la Salud un "+(ataque1 - defensa2)+ " de "+ pokemon2.nombrepokemon() + " y Deja su Salud en " + pokemon2.saludpokemon());
                }

            if (defensa1 >= ataque2){
                pokemon2.reducirsalud(defensa1 - ataque2);
                Console.WriteLine("La Defensa de " + pokemon1.nombrepokemon() + " Reduce la Salud un "+(defensa1 - ataque2)+ " de " + pokemon2.nombrepokemon() + " y Deja su Salud en " + pokemon2.saludpokemon());
                }
            else{
                pokemon1.reducirsalud(ataque2 - defensa1);
                Console.WriteLine("El Ataque de " + pokemon2.nombrepokemon() + " Reduce la Salud un "+(ataque2 - defensa1)+ " de "+ pokemon1.nombrepokemon() + " y Deja su Salud en " + pokemon1.saludpokemon());
            }
        }

        if (pokemon1.saludpokemon() > pokemon2.saludpokemon())
            Console.WriteLine("El Pokemon " + pokemon1.nombrepokemon() + " Ha Ganado");
        else if (pokemon2.saludpokemon() > pokemon1.saludpokemon())
            Console.WriteLine("El Pokémon 2 " + pokemon2.nombrepokemon() + " Ha Ganado");
        else
            Console.WriteLine("Empate");