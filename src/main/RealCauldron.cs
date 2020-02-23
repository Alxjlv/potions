public class RealCauldron : Cauldron
{
    public RealCauldron(int cauldronSize){
        ingredientLimit = cauldronSize;
    }

    public override int getIngredientLimit(){
        return ingredientLimit;
    }

}