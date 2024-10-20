public abstract class ISBN
{
    public string Number { get; }

    protected ISBN(string number)
    {
        Number = number;
    }

    public abstract bool IsValid();
}