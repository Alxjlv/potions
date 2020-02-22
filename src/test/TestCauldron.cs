public class TestCauldron : Cauldron {
    
    public TestCauldron(int ingredientsNum){
        numberOfIngredients = ingredientsNum;
    }

    public override int getNumber(){
        return numberOfIngredients;
    }

}