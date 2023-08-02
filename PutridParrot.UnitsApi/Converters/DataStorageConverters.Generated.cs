// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

using PutridParrot.UnitsApi.Resources;
using PutridParrot.Units;

namespace PutridParrot.UnitsApi.Converters
{
	public partial class DataStorageConverters
	{
		public DataStorageConverters()
		{
			Converters = new Dictionary<string, Dictionary<string, Func<double, double>>>
			{
				{
					AppResources.Bits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Kilobits, DataStorage.Bits.ToKilobits },
						{ AppResources.Megabits, DataStorage.Bits.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Bits.ToGigabits },
						{ AppResources.Terabits, DataStorage.Bits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Bits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Bits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Bits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Bits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Bits.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Bits.ToMebibits },
					}
				},
				{
					AppResources.Gigabits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Gigabits.ToBits },
						{ AppResources.Kilobits, DataStorage.Gigabits.ToKilobits },
						{ AppResources.Megabits, DataStorage.Gigabits.ToMegabits },
						{ AppResources.Terabits, DataStorage.Gigabits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Gigabits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Gigabits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Gigabits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Gigabits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Gigabits.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Gigabits.ToMebibits },
					}
				},
				{
					AppResources.Gigabytes, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Gigabytes.ToBits },
						{ AppResources.Kilobits, DataStorage.Gigabytes.ToKilobits },
						{ AppResources.Megabits, DataStorage.Gigabytes.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Gigabytes.ToGigabits },
						{ AppResources.Terabits, DataStorage.Gigabytes.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Gigabytes.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Gigabytes.ToMegabytes },
						{ AppResources.Terabytes, DataStorage.Gigabytes.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Gigabytes.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Gigabytes.ToMebibits },
					}
				},
				{
					AppResources.Kibibits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Kibibits.ToBits },
						{ AppResources.Kilobits, DataStorage.Kibibits.ToKilobits },
						{ AppResources.Megabits, DataStorage.Kibibits.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Kibibits.ToGigabits },
						{ AppResources.Terabits, DataStorage.Kibibits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Kibibits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Kibibits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Kibibits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Kibibits.ToTerabytes },
						{ AppResources.Mebibits, DataStorage.Kibibits.ToMebibits },
					}
				},
				{
					AppResources.Kilobits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Kilobits.ToBits },
						{ AppResources.Megabits, DataStorage.Kilobits.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Kilobits.ToGigabits },
						{ AppResources.Terabits, DataStorage.Kilobits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Kilobits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Kilobits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Kilobits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Kilobits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Kilobits.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Kilobits.ToMebibits },
					}
				},
				{
					AppResources.Kilobytes, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Kilobytes.ToBits },
						{ AppResources.Kilobits, DataStorage.Kilobytes.ToKilobits },
						{ AppResources.Megabits, DataStorage.Kilobytes.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Kilobytes.ToGigabits },
						{ AppResources.Terabits, DataStorage.Kilobytes.ToTerabits },
						{ AppResources.Megabytes, DataStorage.Kilobytes.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Kilobytes.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Kilobytes.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Kilobytes.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Kilobytes.ToMebibits },
					}
				},
				{
					AppResources.Mebibits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Mebibits.ToBits },
						{ AppResources.Kilobits, DataStorage.Mebibits.ToKilobits },
						{ AppResources.Megabits, DataStorage.Mebibits.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Mebibits.ToGigabits },
						{ AppResources.Terabits, DataStorage.Mebibits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Mebibits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Mebibits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Mebibits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Mebibits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Mebibits.ToKibibits },
					}
				},
				{
					AppResources.Megabits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Megabits.ToBits },
						{ AppResources.Kilobits, DataStorage.Megabits.ToKilobits },
						{ AppResources.Gigabits, DataStorage.Megabits.ToGigabits },
						{ AppResources.Terabits, DataStorage.Megabits.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Megabits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Megabits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Megabits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Megabits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Megabits.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Megabits.ToMebibits },
					}
				},
				{
					AppResources.Megabytes, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Megabytes.ToBits },
						{ AppResources.Kilobits, DataStorage.Megabytes.ToKilobits },
						{ AppResources.Megabits, DataStorage.Megabytes.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Megabytes.ToGigabits },
						{ AppResources.Terabits, DataStorage.Megabytes.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Megabytes.ToKilobytes },
						{ AppResources.Gigabytes, DataStorage.Megabytes.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Megabytes.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Megabytes.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Megabytes.ToMebibits },
					}
				},
				{
					AppResources.Terabits, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Terabits.ToBits },
						{ AppResources.Kilobits, DataStorage.Terabits.ToKilobits },
						{ AppResources.Megabits, DataStorage.Terabits.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Terabits.ToGigabits },
						{ AppResources.Kilobytes, DataStorage.Terabits.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Terabits.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Terabits.ToGigabytes },
						{ AppResources.Terabytes, DataStorage.Terabits.ToTerabytes },
						{ AppResources.Kibibits, DataStorage.Terabits.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Terabits.ToMebibits },
					}
				},
				{
					AppResources.Terabytes, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Bits, DataStorage.Terabytes.ToBits },
						{ AppResources.Kilobits, DataStorage.Terabytes.ToKilobits },
						{ AppResources.Megabits, DataStorage.Terabytes.ToMegabits },
						{ AppResources.Gigabits, DataStorage.Terabytes.ToGigabits },
						{ AppResources.Terabits, DataStorage.Terabytes.ToTerabits },
						{ AppResources.Kilobytes, DataStorage.Terabytes.ToKilobytes },
						{ AppResources.Megabytes, DataStorage.Terabytes.ToMegabytes },
						{ AppResources.Gigabytes, DataStorage.Terabytes.ToGigabytes },
						{ AppResources.Kibibits, DataStorage.Terabytes.ToKibibits },
						{ AppResources.Mebibits, DataStorage.Terabytes.ToMebibits },
					}
				}
			};
		}

		public Dictionary<string, Dictionary<string, Func<double, double>>> Converters { get; }
	}
}