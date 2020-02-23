public class Ingredient{
    
    private string name;

    private string property;

    public Ingredient(string name, string property){
        this.name = name;
        this.property = property;
    }
    public string printAttributes(){
        string attributes = "Name: "+name+" | Property: "+property;
        return attributes;
    }
}