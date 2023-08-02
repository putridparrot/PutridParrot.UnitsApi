using PutridParrot.UnitsApi.Converters;

namespace PutridParrot.UnitsApi;

public class ConverterRepository
{
    public ConverterRepository()
    {
        Converters = new List<IConverters>
        {
            new LengthConverters(),
            new EnergyConverters(),
            new MagnetomotiveForceConverters(),
            new TemperatureConverters(),
            new PressureConverters(),
            new MassConverters(),
            new SpeedConverters(),
            new VolumeConverters(),
            new AngleConverters(),
            new ForceConverters(),
            new FrequencyConverters(),
            new TimeConverters(),
            new AreaConverters(),
            new LuminousEnergyConverters(),
            new DataTransferRateConverters(),
            new DataStorageConverters(),
            new FuelEconomyConverters(),
            new PowerConverters(),
        }.OrderBy(c => c.Name).ToList();
    }

    public IReadOnlyList<IConverters> Converters { get; }

    //public IReadOnlyList<string> Groups => Converters.Select(c => c.Name).OrderBy(i => i).ToList();

    public IReadOnlyList<string> From(string group)
    {
        if (group == null)
            return default;

        var converter = Converters.FirstOrDefault(c => c.Name == group);
        if (converter == null)
            return default;

        return converter.Converters.Keys.OrderBy(i => i).ToList();
    }

    public IReadOnlyList<string> To(string group, string from)
    {
        if (group == null || from == null)
            return default;

        var converter = Converters.FirstOrDefault(c => c.Name == group);
        if (converter == null)
            return default;

        return converter.Converters != null && converter.Converters.ContainsKey(from) ? converter.Converters[from].Keys.OrderBy(i => i).ToList() : default;
    }

    public double Convert(string group, string from, string to, double value)
    {
        if (group == null || from == null || to == null)
            return default;

        var converter = Converters.FirstOrDefault(c => c.Name == group);
        if (converter == null)
            return default;

        var converters = converter.Converters != null && converter.Converters.ContainsKey(from) ? converter.Converters[from] : null;
        return converters != null && converters.ContainsKey(to) ? converters[to].Invoke(value) : default; // TODO maybe better to return nullable if something catastrophic happens
    }
}