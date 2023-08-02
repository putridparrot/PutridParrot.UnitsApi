using Microsoft.AspNetCore.Mvc;

namespace PutridParrot.UnitsApi.Controllers
{
    public class MyConversionController : Controller
    {
        private readonly ConverterRepository _converterRepository;

        public MyConversionController(ConverterRepository converterRepository)
        {
            _converterRepository = converterRepository;
        }

        /// <summary>
        /// The top level categories, i.e. Angle, Area, Length etc.
        /// </summary>
        /// <returns></returns>
        [HttpGet("categories")]
        public Task<List<string>> GetCategories()
        {
            var categories = _converterRepository.Converters.Select(c => c.Name).ToList();
            return Task.FromResult(categories);
        }

        /// <summary>
        /// The units available for the category, so for Angle we
        /// have Degrees, Radians etc.
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        [HttpGet("units")]
        public Task<List<string>> GetUnits(string units)
        {
            var subcategories = _converterRepository.Converters.FirstOrDefault(c => c.Name == units)?.Converters.Keys
                .ToList();

            return Task.FromResult(subcategories ?? new List<string>());
        }

        /// <summary>
        /// The converters this subcategory can convert to, i.e. for Angle
        /// with subcategory Degrees, this list all subcategories minus Degrees
        /// </summary>
        /// <param name="category"></param>
        /// <param name="units"></param>
        /// <returns></returns>
        [HttpGet("convert_to")]
        public Task<List<string>> GetConvertToUnits(string category, string units)
        {
            var converters = _converterRepository.Converters.FirstOrDefault(c => c.Name == category)?
                .Converters[units].Select(kv => kv.Key).ToList();

            if (converters == null)
            {
                throw new ArgumentException("Unable to locate converter for one or more values");
            }

            return Task.FromResult(converters);
        }

        /// <summary>
        /// Use the supplied category, from converter to convert the value to
        /// the to type, for example Angle, convert from Degrees, value 12 to
        /// the to value, such as Radians
        /// </summary>
        /// <param name="category"></param>
        /// <param name="from"></param>
        /// <param name="value"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [HttpGet("convert")]
        public Task<double> GetConverter(string category, string from, double value, string to)
        {
            var converter = _converterRepository.Converters.FirstOrDefault(c => c.Name == category)?
                .Converters[from][to];

            if (converter == null)
            {
                throw new ArgumentException("Unable to locate converter for one or more values");
            }

            return Task.FromResult(converter.Invoke(value));
        }
    }
}
