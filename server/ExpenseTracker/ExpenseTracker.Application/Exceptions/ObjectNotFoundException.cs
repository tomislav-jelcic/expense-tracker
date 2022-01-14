namespace ExpenseTracker.Application.Exceptions;

[System.Serializable]
public class ObjectNotFoundException : System.Exception
{
    public ObjectNotFoundException() { }
    public ObjectNotFoundException(string message) : base(message) { }
    public ObjectNotFoundException(string message, System.Exception inner) : base(message, inner) { }
    protected ObjectNotFoundException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
