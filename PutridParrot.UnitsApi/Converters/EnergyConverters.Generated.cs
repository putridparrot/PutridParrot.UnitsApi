// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

using PutridParrot.UnitsApi.Resources;
using PutridParrot.Units;

namespace PutridParrot.UnitsApi.Converters
{
	public partial class EnergyConverters
	{
		public EnergyConverters()
		{
			Converters = new Dictionary<string, Dictionary<string, Func<double, double>>>
			{
				{
					AppResources.Btu, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.Btu.ToKilojoules },
						{ AppResources.Kilocalories, Energy.Btu.ToKilocalories },
						{ AppResources.Joules, Energy.Btu.ToJoules },
						{ AppResources.Calories, Energy.Btu.ToCalories },
						{ AppResources.USTherms, Energy.Btu.ToUSTherms },
						{ AppResources.WattHours, Energy.Btu.ToWattHours },
						{ AppResources.KilowattHours, Energy.Btu.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Btu.ToFootPounds },
						{ AppResources.Electronvolts, Energy.Btu.ToElectronvolts },
					}
				},
				{
					AppResources.Calories, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.Calories.ToKilojoules },
						{ AppResources.Kilocalories, Energy.Calories.ToKilocalories },
						{ AppResources.Joules, Energy.Calories.ToJoules },
						{ AppResources.Btu, Energy.Calories.ToBtu },
						{ AppResources.USTherms, Energy.Calories.ToUSTherms },
						{ AppResources.WattHours, Energy.Calories.ToWattHours },
						{ AppResources.KilowattHours, Energy.Calories.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Calories.ToFootPounds },
						{ AppResources.Electronvolts, Energy.Calories.ToElectronvolts },
					}
				},
				{
					AppResources.Electronvolts, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.Electronvolts.ToKilojoules },
						{ AppResources.Kilocalories, Energy.Electronvolts.ToKilocalories },
						{ AppResources.Joules, Energy.Electronvolts.ToJoules },
						{ AppResources.Btu, Energy.Electronvolts.ToBtu },
						{ AppResources.Calories, Energy.Electronvolts.ToCalories },
						{ AppResources.USTherms, Energy.Electronvolts.ToUSTherms },
						{ AppResources.WattHours, Energy.Electronvolts.ToWattHours },
						{ AppResources.KilowattHours, Energy.Electronvolts.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Electronvolts.ToFootPounds },
					}
				},
				{
					AppResources.FootPounds, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.FootPounds.ToKilojoules },
						{ AppResources.Kilocalories, Energy.FootPounds.ToKilocalories },
						{ AppResources.Joules, Energy.FootPounds.ToJoules },
						{ AppResources.Btu, Energy.FootPounds.ToBtu },
						{ AppResources.Calories, Energy.FootPounds.ToCalories },
						{ AppResources.USTherms, Energy.FootPounds.ToUSTherms },
						{ AppResources.WattHours, Energy.FootPounds.ToWattHours },
						{ AppResources.KilowattHours, Energy.FootPounds.ToKilowattHours },
						{ AppResources.Electronvolts, Energy.FootPounds.ToElectronvolts },
					}
				},
				{
					AppResources.Joules, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.Joules.ToKilojoules },
						{ AppResources.Kilocalories, Energy.Joules.ToKilocalories },
						{ AppResources.Btu, Energy.Joules.ToBtu },
						{ AppResources.Calories, Energy.Joules.ToCalories },
						{ AppResources.USTherms, Energy.Joules.ToUSTherms },
						{ AppResources.WattHours, Energy.Joules.ToWattHours },
						{ AppResources.KilowattHours, Energy.Joules.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Joules.ToFootPounds },
						{ AppResources.Electronvolts, Energy.Joules.ToElectronvolts },
					}
				},
				{
					AppResources.Kilocalories, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.Kilocalories.ToKilojoules },
						{ AppResources.Joules, Energy.Kilocalories.ToJoules },
						{ AppResources.Btu, Energy.Kilocalories.ToBtu },
						{ AppResources.Calories, Energy.Kilocalories.ToCalories },
						{ AppResources.USTherms, Energy.Kilocalories.ToUSTherms },
						{ AppResources.WattHours, Energy.Kilocalories.ToWattHours },
						{ AppResources.KilowattHours, Energy.Kilocalories.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Kilocalories.ToFootPounds },
						{ AppResources.Electronvolts, Energy.Kilocalories.ToElectronvolts },
					}
				},
				{
					AppResources.Kilojoules, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilocalories, Energy.Kilojoules.ToKilocalories },
						{ AppResources.Joules, Energy.Kilojoules.ToJoules },
						{ AppResources.Btu, Energy.Kilojoules.ToBtu },
						{ AppResources.Calories, Energy.Kilojoules.ToCalories },
						{ AppResources.USTherms, Energy.Kilojoules.ToUSTherms },
						{ AppResources.WattHours, Energy.Kilojoules.ToWattHours },
						{ AppResources.KilowattHours, Energy.Kilojoules.ToKilowattHours },
						{ AppResources.FootPounds, Energy.Kilojoules.ToFootPounds },
						{ AppResources.Electronvolts, Energy.Kilojoules.ToElectronvolts },
					}
				},
				{
					AppResources.KilowattHours, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.KilowattHours.ToKilojoules },
						{ AppResources.Kilocalories, Energy.KilowattHours.ToKilocalories },
						{ AppResources.Joules, Energy.KilowattHours.ToJoules },
						{ AppResources.Btu, Energy.KilowattHours.ToBtu },
						{ AppResources.Calories, Energy.KilowattHours.ToCalories },
						{ AppResources.USTherms, Energy.KilowattHours.ToUSTherms },
						{ AppResources.WattHours, Energy.KilowattHours.ToWattHours },
						{ AppResources.FootPounds, Energy.KilowattHours.ToFootPounds },
						{ AppResources.Electronvolts, Energy.KilowattHours.ToElectronvolts },
					}
				},
				{
					AppResources.USTherms, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.USTherms.ToKilojoules },
						{ AppResources.Kilocalories, Energy.USTherms.ToKilocalories },
						{ AppResources.Joules, Energy.USTherms.ToJoules },
						{ AppResources.Btu, Energy.USTherms.ToBtu },
						{ AppResources.Calories, Energy.USTherms.ToCalories },
						{ AppResources.WattHours, Energy.USTherms.ToWattHours },
						{ AppResources.KilowattHours, Energy.USTherms.ToKilowattHours },
						{ AppResources.FootPounds, Energy.USTherms.ToFootPounds },
						{ AppResources.Electronvolts, Energy.USTherms.ToElectronvolts },
					}
				},
				{
					AppResources.WattHours, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilojoules, Energy.WattHours.ToKilojoules },
						{ AppResources.Kilocalories, Energy.WattHours.ToKilocalories },
						{ AppResources.Joules, Energy.WattHours.ToJoules },
						{ AppResources.Btu, Energy.WattHours.ToBtu },
						{ AppResources.Calories, Energy.WattHours.ToCalories },
						{ AppResources.USTherms, Energy.WattHours.ToUSTherms },
						{ AppResources.KilowattHours, Energy.WattHours.ToKilowattHours },
						{ AppResources.FootPounds, Energy.WattHours.ToFootPounds },
						{ AppResources.Electronvolts, Energy.WattHours.ToElectronvolts },
					}
				}
			};
		}

		public Dictionary<string, Dictionary<string, Func<double, double>>> Converters { get; }
	}
}
