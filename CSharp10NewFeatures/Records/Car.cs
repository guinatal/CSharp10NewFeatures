namespace CSharp10NewFeatures.Records
{
    public record Vehicle(string Name)
    {
        public sealed override string ToString() => Name;
    }

    public record Car(string Name, string Color) : Vehicle(Name);
}
