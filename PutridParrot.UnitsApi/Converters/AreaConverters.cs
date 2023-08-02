using PutridParrot.UnitsApi.Resources;

namespace PutridParrot.UnitsApi.Converters
{
    public partial class AreaConverters : IConverters
    {
        public string Name => AppResources.Area;

        public string IconColour => "#FF0282A3";
        public string Icon =>
            "M2,2L2,19 30,19 30,2z M0,0L32,0 32,21 0,21z";
    }
}