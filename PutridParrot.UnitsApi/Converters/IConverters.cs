namespace PutridParrot.UnitsApi.Converters
{
    public interface IConverters
    {
        Dictionary<string, Dictionary<string, Func<double, double>>> Converters { get; }
        string Name { get; }
        string Icon { get; }
        string IconColour { get; }
    }
}