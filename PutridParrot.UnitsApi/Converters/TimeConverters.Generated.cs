// <auto-generated>
// This code was generated by the UnitCodeGenerator tool
//
// Changes to this file will be lost if the code is regenerated
// </auto-generated>

using PutridParrot.UnitsApi.Resources;
using PutridParrot.Units;

namespace PutridParrot.UnitsApi.Converters
{
	public partial class TimeConverters
	{
		public TimeConverters()
		{
			Converters = new Dictionary<string, Dictionary<string, Func<double, double>>>
			{
				{
					AppResources.Centuries, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Centuries.ToNanoseconds },
						{ AppResources.Microseconds, Time.Centuries.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Centuries.ToMilliseconds },
						{ AppResources.Seconds, Time.Centuries.ToSeconds },
						{ AppResources.Minutes, Time.Centuries.ToMinutes },
						{ AppResources.Hours, Time.Centuries.ToHours },
						{ AppResources.Days, Time.Centuries.ToDays },
						{ AppResources.Weeks, Time.Centuries.ToWeeks },
						{ AppResources.Months, Time.Centuries.ToMonths },
						{ AppResources.Years, Time.Centuries.ToYears },
						{ AppResources.Decades, Time.Centuries.ToDecades },
					}
				},
				{
					AppResources.Days, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Days.ToNanoseconds },
						{ AppResources.Microseconds, Time.Days.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Days.ToMilliseconds },
						{ AppResources.Seconds, Time.Days.ToSeconds },
						{ AppResources.Minutes, Time.Days.ToMinutes },
						{ AppResources.Hours, Time.Days.ToHours },
						{ AppResources.Weeks, Time.Days.ToWeeks },
						{ AppResources.Months, Time.Days.ToMonths },
						{ AppResources.Years, Time.Days.ToYears },
						{ AppResources.Decades, Time.Days.ToDecades },
						{ AppResources.Centuries, Time.Days.ToCenturies },
					}
				},
				{
					AppResources.Decades, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Decades.ToNanoseconds },
						{ AppResources.Microseconds, Time.Decades.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Decades.ToMilliseconds },
						{ AppResources.Seconds, Time.Decades.ToSeconds },
						{ AppResources.Minutes, Time.Decades.ToMinutes },
						{ AppResources.Hours, Time.Decades.ToHours },
						{ AppResources.Days, Time.Decades.ToDays },
						{ AppResources.Weeks, Time.Decades.ToWeeks },
						{ AppResources.Months, Time.Decades.ToMonths },
						{ AppResources.Years, Time.Decades.ToYears },
						{ AppResources.Centuries, Time.Decades.ToCenturies },
					}
				},
				{
					AppResources.Hours, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Hours.ToNanoseconds },
						{ AppResources.Microseconds, Time.Hours.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Hours.ToMilliseconds },
						{ AppResources.Seconds, Time.Hours.ToSeconds },
						{ AppResources.Minutes, Time.Hours.ToMinutes },
						{ AppResources.Days, Time.Hours.ToDays },
						{ AppResources.Weeks, Time.Hours.ToWeeks },
						{ AppResources.Months, Time.Hours.ToMonths },
						{ AppResources.Years, Time.Hours.ToYears },
						{ AppResources.Decades, Time.Hours.ToDecades },
						{ AppResources.Centuries, Time.Hours.ToCenturies },
					}
				},
				{
					AppResources.Microseconds, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Microseconds.ToNanoseconds },
						{ AppResources.Milliseconds, Time.Microseconds.ToMilliseconds },
						{ AppResources.Seconds, Time.Microseconds.ToSeconds },
						{ AppResources.Minutes, Time.Microseconds.ToMinutes },
						{ AppResources.Hours, Time.Microseconds.ToHours },
						{ AppResources.Days, Time.Microseconds.ToDays },
						{ AppResources.Weeks, Time.Microseconds.ToWeeks },
						{ AppResources.Months, Time.Microseconds.ToMonths },
						{ AppResources.Years, Time.Microseconds.ToYears },
						{ AppResources.Decades, Time.Microseconds.ToDecades },
						{ AppResources.Centuries, Time.Microseconds.ToCenturies },
					}
				},
				{
					AppResources.Milliseconds, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Milliseconds.ToNanoseconds },
						{ AppResources.Microseconds, Time.Milliseconds.ToMicroseconds },
						{ AppResources.Seconds, Time.Milliseconds.ToSeconds },
						{ AppResources.Minutes, Time.Milliseconds.ToMinutes },
						{ AppResources.Hours, Time.Milliseconds.ToHours },
						{ AppResources.Days, Time.Milliseconds.ToDays },
						{ AppResources.Weeks, Time.Milliseconds.ToWeeks },
						{ AppResources.Months, Time.Milliseconds.ToMonths },
						{ AppResources.Years, Time.Milliseconds.ToYears },
						{ AppResources.Decades, Time.Milliseconds.ToDecades },
						{ AppResources.Centuries, Time.Milliseconds.ToCenturies },
					}
				},
				{
					AppResources.Minutes, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Minutes.ToNanoseconds },
						{ AppResources.Microseconds, Time.Minutes.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Minutes.ToMilliseconds },
						{ AppResources.Seconds, Time.Minutes.ToSeconds },
						{ AppResources.Hours, Time.Minutes.ToHours },
						{ AppResources.Days, Time.Minutes.ToDays },
						{ AppResources.Weeks, Time.Minutes.ToWeeks },
						{ AppResources.Months, Time.Minutes.ToMonths },
						{ AppResources.Years, Time.Minutes.ToYears },
						{ AppResources.Decades, Time.Minutes.ToDecades },
						{ AppResources.Centuries, Time.Minutes.ToCenturies },
					}
				},
				{
					AppResources.Months, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Months.ToNanoseconds },
						{ AppResources.Microseconds, Time.Months.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Months.ToMilliseconds },
						{ AppResources.Seconds, Time.Months.ToSeconds },
						{ AppResources.Minutes, Time.Months.ToMinutes },
						{ AppResources.Hours, Time.Months.ToHours },
						{ AppResources.Days, Time.Months.ToDays },
						{ AppResources.Weeks, Time.Months.ToWeeks },
						{ AppResources.Years, Time.Months.ToYears },
						{ AppResources.Decades, Time.Months.ToDecades },
						{ AppResources.Centuries, Time.Months.ToCenturies },
					}
				},
				{
					AppResources.Nanoseconds, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Microseconds, Time.Nanoseconds.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Nanoseconds.ToMilliseconds },
						{ AppResources.Seconds, Time.Nanoseconds.ToSeconds },
						{ AppResources.Minutes, Time.Nanoseconds.ToMinutes },
						{ AppResources.Hours, Time.Nanoseconds.ToHours },
						{ AppResources.Days, Time.Nanoseconds.ToDays },
						{ AppResources.Weeks, Time.Nanoseconds.ToWeeks },
						{ AppResources.Months, Time.Nanoseconds.ToMonths },
						{ AppResources.Years, Time.Nanoseconds.ToYears },
						{ AppResources.Decades, Time.Nanoseconds.ToDecades },
						{ AppResources.Centuries, Time.Nanoseconds.ToCenturies },
					}
				},
				{
					AppResources.Seconds, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Seconds.ToNanoseconds },
						{ AppResources.Microseconds, Time.Seconds.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Seconds.ToMilliseconds },
						{ AppResources.Minutes, Time.Seconds.ToMinutes },
						{ AppResources.Hours, Time.Seconds.ToHours },
						{ AppResources.Days, Time.Seconds.ToDays },
						{ AppResources.Weeks, Time.Seconds.ToWeeks },
						{ AppResources.Months, Time.Seconds.ToMonths },
						{ AppResources.Years, Time.Seconds.ToYears },
						{ AppResources.Decades, Time.Seconds.ToDecades },
						{ AppResources.Centuries, Time.Seconds.ToCenturies },
					}
				},
				{
					AppResources.Weeks, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Weeks.ToNanoseconds },
						{ AppResources.Microseconds, Time.Weeks.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Weeks.ToMilliseconds },
						{ AppResources.Seconds, Time.Weeks.ToSeconds },
						{ AppResources.Minutes, Time.Weeks.ToMinutes },
						{ AppResources.Hours, Time.Weeks.ToHours },
						{ AppResources.Days, Time.Weeks.ToDays },
						{ AppResources.Months, Time.Weeks.ToMonths },
						{ AppResources.Years, Time.Weeks.ToYears },
						{ AppResources.Decades, Time.Weeks.ToDecades },
						{ AppResources.Centuries, Time.Weeks.ToCenturies },
					}
				},
				{
					AppResources.Years, new Dictionary<string, Func<double, double>>
					{
						{ AppResources.Nanoseconds, Time.Years.ToNanoseconds },
						{ AppResources.Microseconds, Time.Years.ToMicroseconds },
						{ AppResources.Milliseconds, Time.Years.ToMilliseconds },
						{ AppResources.Seconds, Time.Years.ToSeconds },
						{ AppResources.Minutes, Time.Years.ToMinutes },
						{ AppResources.Hours, Time.Years.ToHours },
						{ AppResources.Days, Time.Years.ToDays },
						{ AppResources.Weeks, Time.Years.ToWeeks },
						{ AppResources.Months, Time.Years.ToMonths },
						{ AppResources.Decades, Time.Years.ToDecades },
						{ AppResources.Centuries, Time.Years.ToCenturies },
					}
				}
			};
		}

		public Dictionary<string, Dictionary<string, Func<double, double>>> Converters { get; }
	}
}
