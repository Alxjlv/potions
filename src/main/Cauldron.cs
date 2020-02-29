using System;
using System.Collections.Generic;
public class Cauldron
{
    private int ingredientLimit;
    private Potion potion;
    private List<Ingredient> ingredients = new List<Ingredient>();

    public Cauldron(int cauldronSize,IngredientStore ingredients){
        ingredientLimit = cauldronSize;
    }

    public int getIngredientLimit(){
        return ingredientLimit;
    }

    public Cauldron mix(){
        throw new NotImplementedException();
    }

    public Cauldron addIngredient(Ingredient ingredient){
        throw new NotImplementedException();
    }

    public Potion extractPotion(){
        throw new NotImplementedException();
    }
}