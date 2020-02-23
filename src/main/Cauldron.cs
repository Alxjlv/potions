using System;
using System.Collections.Generic;
public abstract class Cauldron
{
    protected int ingredientLimit {get;set;}
    protected Potion potion;
    protected List<Ingredient> ingredients = new List<Ingredient>();

    public abstract int getIngredientLimit();

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