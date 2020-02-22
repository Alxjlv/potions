using System;
public abstract class Cauldron
{
    protected int numberOfIngredients {get;set;}
    protected Potion potion {get;set;}

    public abstract int getNumber();

    public Cauldron mix(Ingredient[] ingredients){
        throw new NotImplementedException();
        if(ingredients.Length>numberOfIngredients){
            
        }
        return this;
    }


}