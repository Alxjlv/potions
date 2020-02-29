public class RealCauldron : Cauldron
{
    public RealCauldron(int cauldronSize) : base(cauldronSize) {}

    public override int getIngredientLimit(){
        return ingredientLimit;
    }

}