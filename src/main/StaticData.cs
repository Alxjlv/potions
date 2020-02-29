using System.Collections.Generic;
using System.Collections.ObjectModel;

public static class StaticData{

    public static ReadOnlyDictionary<string, Ingredient> ingredients = new ReadOnlyDictionary<string, Ingredient>
    (
        new Dictionary<string, Ingredient>(){
			{"Nightshade",new Ingredient("Nightshade","Hallucinogenic")},
			{"Hummus",new Ingredient("Hummus","Thickener","Can be applied as a paste")},
			{"Willowbark", new Ingredient("Willowbark","Painkiller")},
			{"Charcoal", new Ingredient("Charcoal", "Poison cure")},
			{"Snake Venom", new Ingredient("Snake Venom", "Poisonous")},
			{"Honey",new Ingredient("Honey", "Antibiotic")}
		}
    );

}