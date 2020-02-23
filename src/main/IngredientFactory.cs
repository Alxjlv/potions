using System;
using System.Collections.Generic;
public class IngredientFactory{
    private Dictionary<string, Ingredient> ingredientStore = new Dictionary<string, Ingredient>();

    private static IngredientFactory instance;

    public static IngredientFactory getInstance(){ //TODO - make constructor thread safe
        if(instance == null){
            instance = new IngredientFactory();
        }
        return instance;
    }

    private IngredientFactory(){
        ingredientStore.Add("Nightshade",new Ingredient("Nightshade","Hallucinogenic"));
    }

    public Ingredient get(string ingredient){
        if(ingredientStore.ContainsKey(ingredient)){
            Ingredient output;
            ingredientStore.TryGetValue(ingredient, out output);
            return output;
        }else{
            throw new IngredientNotFoundException("Ingredient "+ingredient+" not found");
        }
    }
}