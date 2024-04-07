namespace PokemonP.src.clases;

using System.Xml.XPath;
using PokemonP.src.interfaces;

public class Pokemon:IPokemon{

    private string nombre {get; set;}
    private string tipo {get; set;}
    private int salud {get; set;}
    private int [] ataque {get; set;}
    private int [] defensa {get; set;}

    private Random random;

    public Pokemon(string nombre, string tipo){
        this.nombre = nombre;
        this.tipo = tipo;
        this.salud =  100;
        this.ataque= new int[3];
        this.defensa= new int[2];
        this.random= new Random();
        
        for (int i = 0; i <= 2; i++){
            this.ataque[i] = random.Next(0, 41);
        }
        for (int i = 0; i <=1; i++){
            this.defensa[i] = random.Next(10, 36);
        }

    }
    public string nombrepokemon(){
        return this.nombre ;
    }
    public string tipopokemon(){
        return this.tipo ;
    }

    public int saludpokemon(){
        return this.salud;
    }

    public int [] ataquepokemon(){
        return this.ataque;
    }

    public int [] defensapokemon(){
        return this.defensa;
    }
    public int atacarpokemon(){
        int vataque= random.Next(0, 3);
        int resultado= (int)(ataque[vataque]* (random.Next(0, 2) == 0 ? 1 : 1.5));
        return resultado;
    }

    public int defenderpokemon(){
        int vdefensa = random.Next(0, 2);
        int resultado= (int)(defensa[vdefensa] * (random.Next(0, 2) == 0 ? 1 : 0.5));
        return resultado;
    }

    public void reducirsalud(int cantidad)
    {
        salud -= cantidad;
        if (salud < 0)
            salud = 0;
    }
}