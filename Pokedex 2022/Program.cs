//Evolva
//Fråga användaren om vilken pokemon den vill evolva
//Hitta rätt påkemon i listan
//Evolva den pokemon genom en metod i dess klass
//Displaya listan med pokemons


using Class1;

List <Pokemon> pokemons = new ();

PopulatePokemonsList();

//Lägger till några pokemons som finns med från början

void PopulatePokemonsList ()
{
    Pokemon pokemon1 = new();
    pokemons.Add(pokemon1);

    Pokemon pokemon2 = new();
    pokemons.Add(pokemon2);

    Pokemon pokemon3 = new();
    pokemons.Add(pokemon3);

    Pokemon pokemon4 = new();
    pokemons.Add(pokemon4);
}

