public class TestCauldron : Cauldron {
    
    public TestCauldron(int cauldronSize) : base(cauldronSize){}

    public override int getIngredientLimit(){
        return ingredientLimit;
    }

}