public class TestCauldron : Cauldron {
    
    public TestCauldron(int cauldronSize){
        ingredientLimit = cauldronSize;
    }

    public override int getIngredientLimit(){
        return ingredientLimit;
    }

}