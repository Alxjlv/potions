public abstract class Cauldron
{
    protected int numberOfIngredients {get;set;}
    protected Potion potion {get;set;}

    public abstract int getNumber();

    public Cauldron mix(Ingredient[] ingredients){
        if(ingredients.Length()>numberOfIngredients){

        }
    }


}