// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

using PutridParrot.UnitsApi.Resources;
using PutridParrot.Units;

namespace PutridParrot.UnitsApi.Converters
{
	public partial class FuelEconomyConverters
	{
		public FuelEconomyConverters()
		{
			Converters = new Dictionary<string, Dictionary<string, Func<double, double>>>
			{
				{
					AppResources.KilometrePerLitre, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.USMilesPerGallon, FuelEconomy.KilometrePerLitre.ToUSMilesPerGallon },
						{ AppResources.MilesPerGallon, FuelEconomy.KilometrePerLitre.ToMilesPerGallon },
						{ AppResources.LitresPer100Kilometres, FuelEconomy.KilometrePerLitre.ToLitresPer100Kilometres },
					}
				},
				{
					AppResources.LitresPer100Kilometres, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.KilometrePerLitre, FuelEconomy.LitresPer100Kilometres.ToKilometrePerLitre },
						{ AppResources.MilesPerGallon, FuelEconomy.LitresPer100Kilometres.ToMilesPerGallon },
						{ AppResources.USMilesPerGallon, FuelEconomy.LitresPer100Kilometres.ToUSMilesPerGallon },
					}
				},
				{
					AppResources.MilesPerGallon, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.KilometrePerLitre, FuelEconomy.MilesPerGallon.ToKilometrePerLitre },
						{ AppResources.USMilesPerGallon, FuelEconomy.MilesPerGallon.ToUSMilesPerGallon },
						{ AppResources.LitresPer100Kilometres, FuelEconomy.MilesPerGallon.ToLitresPer100Kilometres },
					}
				},
				{
					AppResources.USMilesPerGallon, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.KilometrePerLitre, FuelEconomy.USMilesPerGallon.ToKilometrePerLitre },
						{ AppResources.MilesPerGallon, FuelEconomy.USMilesPerGallon.ToMilesPerGallon },
						{ AppResources.LitresPer100Kilometres, FuelEconomy.USMilesPerGallon.ToLitresPer100Kilometres },
					}
				}
			};
		}

		public Dictionary<string, Dictionary<string, Func<double, double>>> Converters { get; }
	}
}
