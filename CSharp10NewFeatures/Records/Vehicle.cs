namespace CSharp10NewFeatures.Records
{
    public record Vehicle(string Name)
    {
        // Record types can seal ToString
        // In C# 10.0, you can add the sealed modifier when you override ToString in a record type.
        // Sealing the ToString method prevents the compiler from synthesizing a ToString method for any derived record types.
        // This ensures all derived record types use the ToString method defined in a common base record type.
        public sealed override string ToString() => Name;
    }
}
