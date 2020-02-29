public class NoIngredientsException : System.Exception
{
    public NoIngredientsException() { }
    public NoIngredientsException(string message) : base(message) { }
    public NoIngredientsException(string message, System.Exception inner) : base(message, inner) { }
    protected NoIngredientsException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}