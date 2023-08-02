using PutridParrot.UnitsApi.Resources;

namespace PutridParrot.UnitsApi.Converters
{
    public partial class EnergyConverters : IConverters
    {
       public string Name => AppResources.Energy;

        public string IconColour => "#FF29AE4A";

        public string Icon =>
            "M11.771002,1.993L5.0080013,14.284 10.752002,14.284 6.6450019,22.804 17.900003,11.921 11.655003,11.921 18.472004,1.993z M10.593002,0L22.256004,0 15.440003,9.9280005 22.827004,9.9280005 0,32 7.5790019,16.277 1.637001,16.277z";
    }
}