using Xunit;

public class TestRunner{

    [Fact]
    public void testCauldron(){
        Cauldron cauldron = new TestCauldron(4);
        Assert.Equal(4,cauldron.getIngredientLimit());
    }

    [Fact]
    public void testIngredientWhichExists(){
        IngredientFactory factory = IngredientFactory.getInstance();
        Ingredient ingredient = factory.get("Nightshade");
        Assert.Equal("Name: Nightshade | Property: Hallucinogenic",ingredient.printAttributes());
    }

    [Fact]
    public void testIngredientNotFound(){
        IngredientFactory factory = IngredientFactory.getInstance();
        try{
            factory.get("FakeIngredient");
            Assert.True(false,"Exception should have been thrown when the ingredient does not exist");
        }catch(IngredientNotFoundException I){
            Assert.Equal("Ingredient FakeIngredient not found",I.Message);
        }
    }

}