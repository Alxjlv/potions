using Xunit;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class TestRunner{

    static ReadOnlyDictionary<string, Ingredient> _testIngredients = new ReadOnlyDictionary<string, Ingredient>
    (
        new Dictionary<string, Ingredient>(){
			{"Nightshade",new Ingredient("Nightshade","Hallucinogenic")},
			{"Hummus",new Ingredient("Hummus","Thickener","Can be applied as a paste")},
			{"Willowbark", new Ingredient("Willowbark","Painkiller")},
			{"Charcoal", new Ingredient("Charcoal", "Poison cure")},
			{"Snake Venom", new Ingredient("Snake Venom", "Poisonous")},
			{"Honey",new Ingredient("Honey", "Antibiotic")}
		}
    );

    [Fact]
    public void testCauldron(){
        Cauldron cauldron = new TestCauldron(4);
        Assert.Equal(4,cauldron.getIngredientLimit());
    }

    [Fact]
    public void testIngredientWhichExists(){
        IngredientStore testStore = new IngredientStore(_testIngredients);
        Ingredient ingredient = testStore.get("Nightshade");
        Assert.Equal("Name: Nightshade | Property: Hallucinogenic",ingredient.printAttributes());
    }

    [Fact]
    public void testIngredientNotFound(){
        IngredientStore testStore = new IngredientStore(_testIngredients);
        try{
            testStore.get("FakeIngredient");
            Assert.True(false,"Exception should have been thrown when the ingredient does not exist");
        }catch(IngredientNotFoundException I){
            Assert.Equal("Ingredient FakeIngredient not found",I.Message);
        }
    }

    [Fact]
    public void testGetAllKeys(){ //how to test the case where there are no keys in the array? Dependancy Injection?
        IngredientStore testStore = new IngredientStore(_testIngredients);
        string[] keys = testStore.getAllKeys();

    }

}