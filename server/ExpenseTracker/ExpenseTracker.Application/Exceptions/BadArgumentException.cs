namespace ExpenseTracker.Application.Exceptions;

[System.Serializable]
public class BadArgumentException : System.Exception
{
    public BadArgumentException() { }
    public BadArgumentException(string message) : base(message) { }
    public BadArgumentException(string message, System.Exception inner) : base(message, inner) { }
    protected BadArgumentException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
