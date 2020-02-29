using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class IngredientStore { //Singleton might not be the best idea tbh - make nonstatic, and use dependancy injection for the ingredients array?
/*
For example:
public IngredientFactory(ReadOnlyDictionary<string,Ingredient>){...}

*/
	public static ReadOnlyDictionary<string,Ingredient> _readOnlyIngredientStore;
	static IngredientStore(){ //static constructor to initialise the ingredients
		IDictionary<string, Ingredient> ingredientStore = new Dictionary<string, Ingredient>(){
			{"Nightshade",new Ingredient("Nightshade","Hallucinogenic")},
			{"Hummus",new Ingredient("Hummus","Thickener","Can be applied as a paste")},
			{"Willowbark", new Ingredient("Willowbark","Painkiller")},
			{"Charcoal", new Ingredient("Charcoal", "Poison cure")},
			{"Snake Venom", new Ingredient("Snake Venom", "Poisonous")},
			{"Honey",new Ingredient("Honey", "Antibiotic")}
		};
		_readOnlyIngredientStore = new ReadOnlyDictionary<string, Ingredient>(ingredientStore);
	}

    public IngredientStore(ReadOnlyDictionary<string, Ingredient> ingredientList){
		_readOnlyIngredientStore = ingredientList;
    }
	
	public Ingredient get(string ingredient){ //gets a single ingredient
		if(_readOnlyIngredientStore.ContainsKey(ingredient)){
			Ingredient output;
			_readOnlyIngredientStore.TryGetValue(ingredient, out output);
			return output;
		}else{
			throw new IngredientNotFoundException("Ingredient "+ingredient+" not found");
		}
	}

	public string[] getAllKeys(){//get the strings of the keys
		string[] keys = new string[_readOnlyIngredientStore.Count];
        int increment = 0;
        foreach(string key in _readOnlyIngredientStore.Keys){
            keys[increment] = key;
            increment++;
        }
        return keys;
	}

}