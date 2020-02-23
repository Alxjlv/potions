public class Ingredient{
    
    private string name;

    private string property;

    private string description;
    public Ingredient(string name, string property){
        this.name = name;
        this.property = property;
    }

    public Ingredient(string name, string property, string description){
        this.name = name;
        this.property = property;
        this.description = description;
    }

    public string printAttributes(){
        string attributes = "Name: "+name+" | Property: "+property;
        if(description != null){
            attributes += " | Description: "+description;
        }
        return attributes;
    }
}