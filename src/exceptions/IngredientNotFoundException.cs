public class IngredientNotFoundException : System.Exception
{
    public IngredientNotFoundException() { }
    public IngredientNotFoundException(string message) : base(message) { }
    public IngredientNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    protected IngredientNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}