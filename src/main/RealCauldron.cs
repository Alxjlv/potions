public class RealCauldron : Cauldron
{
    public RealCauldron(int ingredientNum){
        numberOfIngredients = ingredientNum;
    }

    public int getIngredientLimit(){
        return numberOfIngredients;
    }
}