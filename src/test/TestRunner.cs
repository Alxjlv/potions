using Xunit;

public class TestRunner{

    [Fact]
    public void setup(){

    }

    [Fact]
    public void testCauldron(){
        Cauldron cauldron = new TestCauldron(4);
        Assert.Equal(4,cauldron.getNumber());
    }

    [Fact]
    public void testCauldronMix(){
        Assert.Equal(5,Add(2,2));
    }

    int Add(int x, int y){
        return x + y;
    }
}